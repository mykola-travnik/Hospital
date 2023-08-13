import { IUser, StorageService } from './storage.service';
import { Injectable } from '@angular/core';
import { AuthClient } from 'src/client/client';
import { AUTH_API } from 'src/utilites';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private authClient = new AuthClient(AUTH_API);

  constructor(private storageService: StorageService) { }

  async login(username: string, password: string): Promise<boolean> {
    try {
      const token = await this.authClient.logIn(username, password)

      const user: IUser = {
        name: username,
        token: token
      }

      this.storageService.saveUser(user)

      return true;
    }
    catch {
      return false;
    }
  }

  async signin(username: string, password: string): Promise<boolean> {
    try {
      const token = await this.authClient.signIn(username, password)

      const user: IUser = {
        name: username,
        token: token
      }

      this.storageService.saveUser(user)
      return true;
    }
    catch {
      return false;
    }
  }
}
