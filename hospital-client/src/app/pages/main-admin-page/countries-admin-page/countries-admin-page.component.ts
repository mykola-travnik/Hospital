import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import {
  ReactiveFormsModule,
} from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { CountryClient, CountryCreateDto, CountryDto, CountryQueryDto } from 'src/client/client';
import { MatTable, MatTableModule } from '@angular/material/table';
import { nameof } from 'src/utilites';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { CountriesAdminPageNewCountryDialogComponent } from './countries-admin-page-new-country-dialog/countries-admin-page-new-country-dialog.component';

@Component({
  selector: 'app-countries-admin-page',
  standalone: true,
  imports: [
    CommonModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    ReactiveFormsModule,
    MatTableModule,
    MatDialogModule
  ],
  templateUrl: './countries-admin-page.component.html',
  styleUrls: ['./countries-admin-page.component.less'],
})
export class CountriesAdminPageComponent implements OnInit {
  private client = new CountryClient('http://localhost:5298');

  public countries: CountryDto[] = []
  public displayedColumns: string[] = [nameof<CountryDto>("name"), 'actions'];

  @ViewChild(MatTable) table!: MatTable<CountryDto>;

  constructor(public dialog: MatDialog) { }

  async ngOnInit(): Promise<void> {
    this.fetchCountries()
  }

  private async fetchCountries() {
    const query = new CountryQueryDto({ name: "" })
    this.countries = await this.client.query(query)
  }

  public openDialog() {
    const dto = new CountryCreateDto({ name: "" })

    const dialogRef = this.dialog.open(CountriesAdminPageNewCountryDialogComponent, {
      data: { dto },
      width: '450px',
      height: '200px',
      enterAnimationDuration: '0ms',
      exitAnimationDuration: '0ms',
    });

    dialogRef.afterClosed().subscribe(async (request: CountryCreateDto) => {
      const dto = await this.client.create(request);
      this.countries.push(dto)
      this.table.renderRows()
    })
  }
}
