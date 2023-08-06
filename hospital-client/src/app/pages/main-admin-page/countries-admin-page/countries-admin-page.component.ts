import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { CountryClient, CountryCreateDto } from 'src/client/client';

@Component({
  selector: 'app-countries-admin-page',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    ReactiveFormsModule,
  ],
  templateUrl: './countries-admin-page.component.html',
  styleUrls: ['./countries-admin-page.component.less'],
})
export class CountriesAdminPageComponent {
  form = new FormGroup({
    title: new FormControl<string>('', [Validators.required]),
  });

  get title() {
    return this.form.controls.title as FormControl;
  }

  public async submit() {
    if (this.form?.valid) {
      const client = new CountryClient('http://localhost:5298');
      const request = new CountryCreateDto({
        name: this.form.controls.title.value!,
      });

      const response = await client.create(request);
      console.warn(response);
    }
  }
}
