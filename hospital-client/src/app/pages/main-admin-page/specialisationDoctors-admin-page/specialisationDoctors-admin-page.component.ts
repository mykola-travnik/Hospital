import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import {
  SpecialisationDoctorClient,
  SpecialisationDoctorCreateDto,
  SpecialisationDoctorDto,
  SpecialisationDoctorQueryDto,
} from 'src/client/client';
import { MatTable, MatTableModule } from '@angular/material/table';
import { nameof } from 'src/utilites';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { SpecialisationDoctorsAdminPageNewSpecialisationDoctorDialogComponent } from './specialisationDoctors-admin-page-new-specialisationDoctor-dialog/specialisationDoctors-admin-page-new-specialisationDoctor-dialog.component';

@Component({
  selector: 'app-specialisationDoctors-admin-page',
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
  templateUrl: './specialisationDoctors-admin-page.component.html',
  styleUrls: ['./specialisationDoctors-admin-page.component.less'],
})
export class SpecialisationDoctorsAdminPageComponent implements OnInit {
  private client = new SpecialisationDoctorClient('http://localhost:5298');

  public specialisationDoctors: SpecialisationDoctorDto[] = [];
  public displayedColumns: string[] = [
    nameof<SpecialisationDoctorDto>('doctor'),
    nameof<SpecialisationDoctorDto>('specialisation'),
    nameof<SpecialisationDoctorDto>('experience'),
  ];

  @ViewChild(MatTable) table!: MatTable<SpecialisationDoctorDto>;

  constructor(public dialog: MatDialog) {}

  async ngOnInit(): Promise<void> {
    this.fetchSpecialisationDoctors();
  }

  private async fetchSpecialisationDoctors() {
    const query = new SpecialisationDoctorQueryDto({
      experience: new Date(),
    });
    this.specialisationDoctors = await this.client.query(query);
  }

  public openDialog() {
    const dto = new SpecialisationDoctorCreateDto({ experience: new Date() });

    const dialogRef = this.dialog.open(
      SpecialisationDoctorsAdminPageNewSpecialisationDoctorDialogComponent,
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
      .subscribe(async (request: SpecialisationDoctorCreateDto) => {
        const dto = await this.client.create(request);
        this.specialisationDoctors.push(dto);
        this.table.renderRows();
      });
  }
}
