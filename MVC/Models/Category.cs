using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public List<Content> Content { get; set; } // контент относящийся к нужной категории
    }
}
