import { Component, Inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { CountryClient, CountryDto } from 'src/client/client';
import { MAT_DIALOG_DATA, MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { NgIf } from '@angular/common';


export interface DialogData {
  dto: CountryDto;
}

@Component({
  selector: 'app-countries-admin-page-new-country-dialog',
  standalone: true,
  imports: [
    CommonModule,
    MatInputModule,
    MatButtonModule,
    NgIf,
    MatDialogModule
  ],
  templateUrl: './countries-admin-page-new-country-dialog.component.html',
  styleUrls: ['./countries-admin-page-new-country-dialog.component.less']
})
export class CountriesAdminPageNewCountryDialogComponent {
  private client = new CountryClient('http://localhost:5298');

  constructor(
    public dialogRef: MatDialogRef<CountriesAdminPageNewCountryDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData,
  ) {
  }

  /// TODO: Подумать как можно сделать лучше
  public getValue(value: string) {
    this.data.dto.name = value
  }
}
