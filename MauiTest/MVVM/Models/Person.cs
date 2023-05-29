﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.MVVM.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        public DateTime BirthDate { get; set; }
        public float Weight { get; set; }
        public TimeSpan LunchTime { get; set; }
        public string Phone { get; set; }
    }
}