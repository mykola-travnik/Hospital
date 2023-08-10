import { Component, EventEmitter, Inject, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { HospitalClient, HospitalDto } from 'src/client/client';
import {
  MAT_DIALOG_DATA,
  MatDialogModule,
  MatDialogRef,
} from '@angular/material/dialog';
import { NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';

export interface DialogData {
  dto: HospitalDto;
}

@Component({
  selector: 'app-hospitals-admin-page-new-hospital-dialog',
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
  templateUrl: './hospitals-admin-page-new-hospital-dialog.component.html',
  styleUrls: ['./hospitals-admin-page-new-hospital-dialog.component.less'],
})
export class HospitalsAdminPageNewHospitalDialogComponent {
  private client = new HospitalClient('http://localhost:5298');
  value = 'Clear me';
  @Input() name: string = '';
  @Output() nameChange = new EventEmitter<string>();

  constructor(
    public dialogRef: MatDialogRef<HospitalsAdminPageNewHospitalDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData
  ) {}

  /// TODO: Подумать как можно сделать лучше
  public getValue(value: string) {
    this.data.dto.name = value;
  }
}
