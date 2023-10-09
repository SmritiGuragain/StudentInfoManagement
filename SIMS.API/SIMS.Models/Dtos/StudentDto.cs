﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.Models.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ImageURL { get; set; }
        public int Sem_Id { get; set; }
        public string Sem_Name {  get; set; }
        public int Fac_Id { get; set; }
        public string Fac_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
