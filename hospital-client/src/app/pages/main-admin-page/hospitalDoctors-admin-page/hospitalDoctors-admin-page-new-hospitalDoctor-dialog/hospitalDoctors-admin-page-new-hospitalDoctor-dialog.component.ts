import { Component, EventEmitter, Inject, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { HospitalDoctorClient, HospitalDoctorDto } from 'src/client/client';
import {
  MAT_DIALOG_DATA,
  MatDialogModule,
  MatDialogRef,
} from '@angular/material/dialog';
import { NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';

export interface DialogData {
  dto: HospitalDoctorDto;
}

@Component({
  selector: 'app-hospitalDoctors-admin-page-new-hospitalDoctor-dialog',
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
  templateUrl:
    './hospitalDoctors-admin-page-new-hospitalDoctor-dialog.component.html',
  styleUrls: [
    './hospitalDoctors-admin-page-new-hospitalDoctor-dialog.component.less',
  ],
})
export class HospitalDoctorsAdminPageNewHospitalDoctorDialogComponent {
  private client = new HospitalDoctorClient('http://localhost:5298');
  value = 'Clear me';
  @Input() name: string = '';
  @Output() nameChange = new EventEmitter<string>();

  constructor(
    public dialogRef: MatDialogRef<HospitalDoctorsAdminPageNewHospitalDoctorDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData
  ) {}

  // /// TODO: Подумать как можно сделать лучше
  // public getValue(value: double) {
  //   this.data.dto.price = value;
  // }
}
