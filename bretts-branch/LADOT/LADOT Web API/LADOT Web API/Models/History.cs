﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LADOT_Web_API.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public string carId { get; set; }
        public string status { get; set; }
        public int lastFuel { get; set; }
        public int currentFuel { get; set; }
        public string comments { get; set; }
        public int lastMileage { get; set; }
        public int currentMileage { get; set; }
        public string email { get; set; }
        public string updated { get; set; }
        public string duedate { get; set; }
        public string name { get; set; }
        public string destination { get; set; }
    }
}