using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperClass
{
    public class Serials : Category //реализовать учет текущей серии и статус (закончен или нет)
    {
        public int CurrentSeries { get; set; }
        public bool Status { get; set; }
    }
}
