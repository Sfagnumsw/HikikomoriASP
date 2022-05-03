using HikikomoriWEB.MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace HikikomoriWEB.Domain.Entity
{
    public abstract class EntityBase //базовый класс для доменной модели
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название")]
        public virtual string Name { get; set; }

        [Display(Name = "Категория")]
        public virtual Category Category { get; set; } //реализовать выбор из нескольких категорий

        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        [Display(Name = "Автор")]
        public string Autor { get; set; }

        [Display(Name = "Год выпуска")]
        public int CreationYear { get; set; }
    }
}
