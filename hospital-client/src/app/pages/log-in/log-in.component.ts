import { Component } from '@angular/core';
import { CommonModule, NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { AuthService } from 'src/_services/auth.service';
import { IUserCredentials } from '../../interfaces/IUserCredentials';
import { Router } from '@angular/router';

@Component({
  selector: 'app-log-in',
  standalone: true,
  imports: [CommonModule,
    MatInputModule,
    MatButtonModule,
    MatFormFieldModule,
    FormsModule,
    MatIconModule],
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.less']
})
export class LogInComponent {
  public user: IUserCredentials = this.defaultUserCreds()
  public hide = true;
  public loginSuccess = true;

  constructor(private authService: AuthService, private router: Router) { }

  public async login() {
    this.loginSuccess = await this.authService.login(this.user.login, this.user.password)

    if (this.loginSuccess)
      this.router.navigate(['/main'])
  }

  private defaultUserCreds(): IUserCredentials {
    return {
      login: '',
      password: ''
    }
  }
}
