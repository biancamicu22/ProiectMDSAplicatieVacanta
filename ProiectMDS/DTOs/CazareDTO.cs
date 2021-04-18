﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMDS.DTOs
{
    public class CazareDTO
    {
        public string Nume { get; set; }
        public string TipCazare { get; set; }
        public float Pret { get; set; }
        public string Oras { get; set; }
        public string Adresa { get; set; }
        public List<int> PachetID { get; set; }
        public List<int> RezervareCazareID { get; set; }
    }
}
