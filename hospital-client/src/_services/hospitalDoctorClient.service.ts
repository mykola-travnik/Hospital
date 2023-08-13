import { Injectable } from '@angular/core';
import axios from 'axios';
import { HospitalDoctorClient } from 'src/client/client';
import { AUTH_API } from 'src/utilites';
import { StorageService } from './storage.service';

const AUTHORIZATION_HEADER = "Authorization"

@Injectable({
  providedIn: 'root'
})
export class HospitalDoctorClientService extends HospitalDoctorClient {
  constructor(storageService: StorageService) {
    const user = storageService.getUser()

    const instance = axios.create({
      baseURL: AUTH_API,
      headers: { [AUTHORIZATION_HEADER]: user?.token ?? '' }
    });

    super(undefined, instance)
  }
}
