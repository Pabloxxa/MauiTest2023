using MauiTest.MVVM.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Person = new Person()
            {
                Name = "Juan Pablo Ossa Ríos.",
                Address="El Guayabo",
                Age = 38,
                Phone ="324 366 82 17",
                BirthDate = new DateTime(1984,5,31),
                IsMarried = false,
                LunchTime = new TimeSpan(12,0,0),
                Weight = 72,
            };
        }

        public Person Person{ get; set; }
    }
}
