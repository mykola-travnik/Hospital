import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import {
  HospitalClient,
  HospitalCreateDto,
  HospitalDto,
  HospitalQueryDto,
} from 'src/client/client';
import { MatTable, MatTableModule } from '@angular/material/table';
import { nameof } from 'src/utilites';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { HospitalsAdminPageNewHospitalDialogComponent } from './hospitals-admin-page-new-hospital-dialog/hospitals-admin-page-new-hospital-dialog.component';

@Component({
  selector: 'app-hospitals-admin-page',
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
  templateUrl: './hospitals-admin-page.component.html',
  styleUrls: ['./hospitals-admin-page.component.less'],
})
export class HospitalsAdminPageComponent implements OnInit {
  private client = new HospitalClient('http://localhost:5298');

  public hospitals: HospitalDto[] = [];
  public displayedColumns: string[] = [
    nameof<HospitalDto>('name'),
    nameof<HospitalDto>('address'),
    nameof<HospitalDto>('photo'),
    nameof<HospitalDto>('cityId'),
  ];

  @ViewChild(MatTable) table!: MatTable<HospitalDto>;

  constructor(public dialog: MatDialog) {}

  async ngOnInit(): Promise<void> {
    this.fetchHospitals();
  }

  private async fetchHospitals() {
    const query = new HospitalQueryDto({ name: '' });
    this.hospitals = await this.client.query(query);
  }

  public openDialog() {
    const dto = new HospitalCreateDto({ name: '' });

    const dialogRef = this.dialog.open(
      HospitalsAdminPageNewHospitalDialogComponent,
      {
        data: { dto },
        width: '450px',
        height: '200px',
        enterAnimationDuration: '0ms',
        exitAnimationDuration: '0ms',
      }
    );

    dialogRef.afterClosed().subscribe(async (request: HospitalCreateDto) => {
      const dto = await this.client.create(request);
      this.hospitals.push(dto);
      this.table.renderRows();
    });
  }
}
