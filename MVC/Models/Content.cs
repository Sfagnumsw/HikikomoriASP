using System.ComponentModel.DataAnnotations;
using HikikomoriWEB.Domain.Entity;

namespace HikikomoriWEB.MVC.Models
{
    public class Content : EntityBase
    {
        [Display(Name = "Флаг пересмотра")]
        public bool Replay { get; set; } //пересмотрел бы контент?

        [Display(Name = "Оценка")]
        public int Rating { get; set; } //оценка
    }
}
