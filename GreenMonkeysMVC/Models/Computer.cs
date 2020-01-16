﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenMonkeysMVC.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? DecomissionDate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
