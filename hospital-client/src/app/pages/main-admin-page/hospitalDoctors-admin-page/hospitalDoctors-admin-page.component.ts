import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import {
  HospitalDoctorClient,
  HospitalDoctorCreateDto,
  HospitalDoctorDto,
  HospitalDoctorQueryDto,
} from 'src/client/client';
import { MatTable, MatTableModule } from '@angular/material/table';
import { nameof } from 'src/utilites';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { HospitalDoctorsAdminPageNewHospitalDoctorDialogComponent } from './hospitalDoctors-admin-page-new-hospitalDoctor-dialog/hospitalDoctors-admin-page-new-hospitalDoctor-dialog.component';

@Component({
  selector: 'app-hospitalDoctors-admin-page',
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
  templateUrl: './hospitalDoctors-admin-page.component.html',
  styleUrls: ['./hospitalDoctors-admin-page.component.less'],
})
export class HospitalDoctorsAdminPageComponent implements OnInit {
  private client = new HospitalDoctorClient('http://localhost:5298');

  public hospitalDoctors: HospitalDoctorDto[] = [];
  public displayedColumns: string[] = [
    nameof<HospitalDoctorDto>('hospital'),
    nameof<HospitalDoctorDto>('doctor'),
    nameof<HospitalDoctorDto>('specialisation'),
    nameof<HospitalDoctorDto>('price'),
  ];

  @ViewChild(MatTable) table!: MatTable<HospitalDoctorDto>;

  constructor(public dialog: MatDialog) { }

  async ngOnInit(): Promise<void> {
    this.fetchHospitalDoctors();
  }

  private async fetchHospitalDoctors() {
    const query = new HospitalDoctorQueryDto({ price: 0 });
    this.hospitalDoctors = await this.client.query(query);
  }

  public openDialog() {
    const dto = new HospitalDoctorCreateDto({ price: 0 });

    const dialogRef = this.dialog.open(
      HospitalDoctorsAdminPageNewHospitalDoctorDialogComponent,
      {
        data: { dto },
        width: '450px',
        height: '200px',
        enterAnimationDuration: '0ms',
        exitAnimationDuration: '0ms',
      }
    );

    dialogRef
      .afterClosed()
      .subscribe(async (request: HospitalDoctorCreateDto) => {
        const dto = await this.client.create(request);
        this.hospitalDoctors.push(dto);
        this.table.renderRows();
      });
  }
}
