import { Component, EventEmitter, Inject, Input, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import {
  SpecialisationDoctorClient,
  SpecialisationDoctorDto,
} from 'src/client/client';
import {
  MAT_DIALOG_DATA,
  MatDialogModule,
  MatDialogRef,
} from '@angular/material/dialog';
import { NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';

export interface DialogData {
  dto: SpecialisationDoctorDto;
}

@Component({
  selector:
    'app-specialisationDoctors-admin-page-new-specialisationDoctor-dialog',
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
    './specialisationDoctors-admin-page-new-specialisationDoctor-dialog.component.html',
  styleUrls: [
    './specialisationDoctors-admin-page-new-specialisationDoctor-dialog.component.less',
  ],
})
export class SpecialisationDoctorsAdminPageNewSpecialisationDoctorDialogComponent {
  private client = new SpecialisationDoctorClient('http://localhost:5298');
  value = 'Clear me';
  @Input() name: string = '';
  @Output() nameChange = new EventEmitter<string>();

  constructor(
    public dialogRef: MatDialogRef<SpecialisationDoctorsAdminPageNewSpecialisationDoctorDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData
  ) {}

  // /// TODO: Подумать как можно сделать лучше
  // public getValue(value: double) {
  //   this.data.dto.price = value;
  // }
}
