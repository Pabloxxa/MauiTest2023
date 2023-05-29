using MauiTest.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            People = new(){
                new Person {Name="Juan",Age=38,BirthDate=new DateTime(1984,5,31),IsMarried=false,LunchTime=new TimeSpan(12,0,0),Address="El Guayabo",Phone="3243668217",Weight=72,},
                new Person {Name="Juan Camilo",Age=42,BirthDate=new DateTime(1980,4,11),IsMarried=false,LunchTime=new TimeSpan(12,0,0),Address="Castilla",Phone="311123456",Weight=82,},
                new Person {Name="Nancy",Age=72,BirthDate=new DateTime(1949,12,30),IsMarried=true,LunchTime=new TimeSpan(12,0,0),Address="El Guayabo",Phone="3117199250",Weight=64,},
                new Person {Name="Juan José",Age=13,BirthDate=new DateTime(2010,2,12),IsMarried=false,LunchTime=new TimeSpan(12,0,0),Address="San Cristóbal",Phone="3243668217",Weight=72,},
                new Person {Name="Moisés",Age=8,BirthDate=new DateTime(2016,1,1),IsMarried=false,LunchTime=new TimeSpan(12,0,0),Address="Villa nueva",Phone="3243668217",Weight=72,},
                new Person {Name="Simón",Age=4,BirthDate=new DateTime(2018,9,10),IsMarried=false,LunchTime=new TimeSpan(12,0,0),Address="La Ilusión",Phone="3243668217",Weight=72,},
                new Person {Name="Yolima",Age=38,BirthDate=new DateTime(1990,8,30),IsMarried=false,LunchTime=new TimeSpan(12,0,0),Address="El Guayabo",Phone="3243668217",Weight=72,}
             };
        }

        public List<Person> People { get; set; }
    }
}
