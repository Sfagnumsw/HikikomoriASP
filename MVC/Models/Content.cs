using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; } //реализовать выбор из нескольких категорий
        public string Genre { get; set; }
        public string Autor { get; set; }
        public int CreationYear { get; set; }
        public string Img { get; set; }
        public int Rating { get; set; } //оценка
        public bool Replay { get; set; } //пересмотрел бы контент?
    }
}
