﻿using CvApp.DTO.Interfaces;
using System;

namespace CvApp.DTO.DTOs.EducationDtos
{
    public class EducationAddDto : IDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
