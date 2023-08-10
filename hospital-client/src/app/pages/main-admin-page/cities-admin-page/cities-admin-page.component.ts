import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import {
  CityClient,
  CityCreateDto,
  CityDto,
  CityQueryDto,
} from 'src/client/client';
import { MatTable, MatTableModule } from '@angular/material/table';
import { nameof } from 'src/utilites';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { citiesAdminPageNewCityDialogComponent } from './cities-admin-page-new-city-dialog/cities-admin-page-new-city-dialog.component';

@Component({
  selector: 'app-cities-admin-page',
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
  templateUrl: './cities-admin-page.component.html',
  styleUrls: ['./cities-admin-page.component.less'],
})
export class CitiesAdminPageComponent implements OnInit {
  private client = new CityClient('http://localhost:5298');

  public cities: CityDto[] = [];
  public displayedColumns: string[] = [nameof<CityDto>('name'), 'actions'];

  @ViewChild(MatTable) table!: MatTable<CityDto>;

  constructor(public dialog: MatDialog) {}

  async ngOnInit(): Promise<void> {
    this.fetchcities();
  }

  private async fetchcities() {
    const query = new CityQueryDto({ name: '' });
    this.cities = await this.client.query(query);
  }

  public openDialog() {
    const dto = new CityCreateDto({ name: '' });

    const dialogRef = this.dialog.open(citiesAdminPageNewCityDialogComponent, {
      data: { dto },
      width: '450px',
      height: '200px',
      enterAnimationDuration: '0ms',
      exitAnimationDuration: '0ms',
    });

    dialogRef.afterClosed().subscribe(async (request: CityCreateDto) => {
      const dto = await this.client.create(request);
      this.cities.push(dto);
      this.table.renderRows();
    });
  }
}
