import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { HospitalDoctorClientService } from 'src/_services/hospitalDoctorClient.service';
import { HospitalDoctorDto, HospitalDoctorQueryDto } from 'src/client/client';

@Component({
  selector: 'app-main-page',
  standalone: true,
  imports: [MatCardModule, MatButtonModule, CommonModule],
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.less']
})
export class MainPageComponent implements OnInit {
  public doctors: HospitalDoctorDto[] = []

  constructor(private hospitalDoctorClientService: HospitalDoctorClientService) {
  }

  async ngOnInit(): Promise<void> {
    const query = new HospitalDoctorQueryDto()
    this.doctors = await this.hospitalDoctorClientService.query(query)
  }

  public meetWithDoctor() {

  }
}
