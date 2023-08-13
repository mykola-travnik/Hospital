import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { AuthService } from 'src/_services/auth.service';
import { IUserCredentials } from 'src/app/interfaces/IUserCredentials';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-in',
  standalone: true,
  imports: [CommonModule,
    MatInputModule,
    MatButtonModule,
    MatFormFieldModule,
    FormsModule,
    MatIconModule],
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.less']
})
export class SignInComponent {
  public user: IUserCredentials = this.defaultUserCreds()
  public hide = true;

  constructor(private authService: AuthService, private router: Router) { }

  public async login() {
    this.authService.signin(this.user.login, this.user.password)
    this.router.navigate(['/main'])
  }

  private defaultUserCreds(): IUserCredentials {
    return {
      login: '',
      password: ''
    }
  }
}
