import { Component } from '@angular/core';
import { CommonModule, NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { AuthService } from 'src/_services/auth.service';


interface IUserCredentials {
  login: string
  password: string
}

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

  constructor(private authService: AuthService) { }

  public async login() {
    this.authService.login(this.user.login, this.user.password)
  }

  private defaultUserCreds(): IUserCredentials {
    return {
      login: '',
      password: ''
    }
  }
}
