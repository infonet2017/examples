﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreEFEXample.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string  FirstName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
