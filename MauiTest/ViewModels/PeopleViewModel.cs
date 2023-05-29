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
             "Juan",
             "Luna",
             "Otawa",
             "Juan José",
             "Atenea",
             "Tilin",
             "Isis",
             "Gaia",
             "Toño",
             };
        }

        public List<string> People { get; set; }
    }
}
