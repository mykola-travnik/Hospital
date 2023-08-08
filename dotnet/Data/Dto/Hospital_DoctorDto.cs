﻿using Domain;

public class Hospital_DoctorDto : BaseDto
{
    public Guid HospitalId { get; set; }
    public Guid DoctorId { get; set; }
    public Guid SpecialisationId { get; set; } 
    public double? Price { get; set; }
}


