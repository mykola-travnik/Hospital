import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import {
  DoctorClient,
  DoctorCreateDto,
  DoctorDto,
  DoctorQueryDto,
} from 'src/client/client';
import { MatTable, MatTableModule } from '@angular/material/table';
import { nameof } from 'src/utilites';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { DoctorsAdminPageNewDoctorDialogComponent } from './doctors-admin-page-new-doctor-dialog/doctors-admin-page-new-doctor-dialog.component';

@Component({
  selector: 'app-doctors-admin-page',
  standalone: true,
  imports: [
    CommonModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    ReactiveFormsModule,
    MatTableModule,
    MatDialogModule,
  ],
  templateUrl: './doctors-admin-page.component.html',
  styleUrls: ['./doctors-admin-page.component.less'],
})
export class DoctorsAdminPageComponent implements OnInit {
  private client = new DoctorClient('http://localhost:5298');

  public doctors: DoctorDto[] = [];
  public displayedColumns: string[] = [
    nameof<DoctorDto>('firstName'),
    'actions',
  ];

  @ViewChild(MatTable) table!: MatTable<DoctorDto>;

  constructor(public dialog: MatDialog) {}

  async ngOnInit(): Promise<void> {
    this.fetchDoctors();
  }

  private async fetchDoctors() {
    const query = new DoctorQueryDto({ fullName: '' });
    this.doctors = await this.client.query(query);
  }

  public openDialog() {
    const dto = new DoctorCreateDto({ firstName: '' });

    const dialogRef = this.dialog.open(
      DoctorsAdminPageNewDoctorDialogComponent,
      {
        data: { dto },
        width: '450px',
        height: '200px',
        enterAnimationDuration: '0ms',
        exitAnimationDuration: '0ms',
      }
    );

    dialogRef.afterClosed().subscribe(async (request: DoctorCreateDto) => {
      const dto = await this.client.create(request);
      this.doctors.push(dto);
      this.table.renderRows();
    });
  }
}
