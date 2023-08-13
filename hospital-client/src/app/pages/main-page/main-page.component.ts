import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { HospitalDoctorClientService } from 'src/_services/hospitalDoctorClient.service';
import { HospitalDoctorDto, HospitalDoctorQueryDto, RecordToDoctorCreateDto } from 'src/client/client';
import { RecordToDoctorClientService } from 'src/_services/recordToDoctorClient.service';

@Component({
  selector: 'app-main-page',
  standalone: true,
  imports: [MatCardModule, MatButtonModule, CommonModule],
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.less']
})
export class MainPageComponent implements OnInit {
  public doctors: HospitalDoctorDto[] = []

  constructor(private hospitalDoctorClientService: HospitalDoctorClientService, private recordToDoctorClientService: RecordToDoctorClientService) {
  }

  async ngOnInit(): Promise<void> {
    const query = new HospitalDoctorQueryDto()
    this.doctors = await this.hospitalDoctorClientService.query(query)
  }

  public meetWithDoctor(hospitalDoctor: HospitalDoctorDto) {
    // TODO: Прокидывать ID из токена. Добавить модалку с datepicker
    // Страницу личного кабинета пользователя где списком выводить записи пользователя
    const request = new RecordToDoctorCreateDto({
      hospitalDoctorId: hospitalDoctor.id,
      userId: 'f790c5d9-b614-4b39-80e9-de46d54c1e95',
      recordTime: new Date()
    })
    this.recordToDoctorClientService.create(request)
  }
}
