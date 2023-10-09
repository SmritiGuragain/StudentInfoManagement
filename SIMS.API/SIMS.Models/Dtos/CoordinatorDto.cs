﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.Models.Dtos
{
    public class CoordinatorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Fac_Id { get; set; }
        public string Fac_Name { get; set; }

    }
}