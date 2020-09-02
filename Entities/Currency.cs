﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTrackingSystem.API.Entities
{
    public class currency
    {
        [Key]
        public int Id { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
       
    }
}
