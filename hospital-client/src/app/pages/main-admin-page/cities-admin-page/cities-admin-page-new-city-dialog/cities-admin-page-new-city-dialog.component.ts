import { Component, EventEmitter, Inject, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { CityClient, CityDto } from 'src/client/client';
import {
  MAT_DIALOG_DATA,
  MatDialogModule,
  MatDialogRef,
} from '@angular/material/dialog';
import { NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';

export interface DialogData {
  dto: CityDto;
}

@Component({
  selector: 'app-cities-admin-page-new-city-dialog',
  standalone: true,
  imports: [
    CommonModule,
    MatInputModule,
    MatButtonModule,
    NgIf,
    MatDialogModule,
    MatFormFieldModule,
    FormsModule,
  ],
  templateUrl: './cities-admin-page-new-city-dialog.component.html',
  styleUrls: ['./cities-admin-page-new-city-dialog.component.less'],
})
export class citiesAdminPageNewCityDialogComponent {
  private client = new CityClient('http://localhost:5298');
  value = 'Clear me';
  @Input() name: string = '';
  @Output() nameChange = new EventEmitter<string>();

  constructor(
    public dialogRef: MatDialogRef<citiesAdminPageNewCityDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData
  ) {}

  /// TODO: Подумать как можно сделать лучше
  public getValue(value: string) {
    this.data.dto.name = value;
  }
}
