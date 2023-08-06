import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-main-admin-page',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './main-admin-page.component.html',
  styleUrls: ['./main-admin-page.component.less'],
})
export class MainAdminPageComponent {}
