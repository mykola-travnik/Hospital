import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import {
  SpecialisationClient,
  SpecialisationCreateDto,
  SpecialisationDto,
  SpecialisationQueryDto,
} from 'src/client/client';
import { MatTable, MatTableModule } from '@angular/material/table';
import { nameof } from 'src/utilites';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { SpecialisationsAdminPageNewSpecialisationDialogComponent } from './specialisations-admin-page-new-specialisation-dialog/specialisations-admin-page-new-specialisation-dialog.component';

@Component({
  selector: 'app-specialisations-admin-page',
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
  templateUrl: './specialisations-admin-page.component.html',
  styleUrls: ['./specialisations-admin-page.component.less'],
})
export class SpecialisationsAdminPageComponent implements OnInit {
  private client = new SpecialisationClient('http://localhost:5298');

  public specialisations: SpecialisationDto[] = [];
  public displayedColumns: string[] = [nameof<SpecialisationDto>('name')];

  @ViewChild(MatTable) table!: MatTable<SpecialisationDto>;

  constructor(public dialog: MatDialog) { }

  async ngOnInit(): Promise<void> {
    this.fetchSpecialisations();
  }

  private async fetchSpecialisations() {
    const query = new SpecialisationQueryDto({ name: '' });
    this.specialisations = await this.client.query(query);
  }

  public openDialog() {
    const dto = new SpecialisationCreateDto({ name: '' });

    const dialogRef = this.dialog.open(
      SpecialisationsAdminPageNewSpecialisationDialogComponent,
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
      .subscribe(async (request: SpecialisationCreateDto) => {
        const dto = await this.client.create(request);
        this.specialisations.push(dto);
        this.table.renderRows();
      });
  }
}
