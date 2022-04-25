using System.ComponentModel.DataAnnotations;
using HikikomoriWEB.Domain.Entity;

namespace HikikomoriWEB.MVC.Models
{
    public class Content : EntityBase
    {
        [Required]
        [Display(Name = "Название")]
        public override string Name { get; set; }

        [Display(Name = "Категория")]
        public virtual Category Category { get; set; } //реализовать выбор из нескольких категорий

        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        [Display(Name = "Автор")]
        public string Autor { get; set; }

        [Display(Name = "Год выпуска")]
        public int CreationYear { get; set; }

        [Display(Name = "Оценка")]
        public int Rating { get; set; } //оценка

        [Display(Name = "Флаг пересмотра")]
        public bool Replay { get; set; } //пересмотрел бы контент?
    }
}
