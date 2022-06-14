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

        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        [Display(Name = "Автор")]
        public string Autor { get; set; }

        [Display(Name = "Год выпуска")]
        public int CreationYear { get; set; }

        //связь с Category
        [Required]
        [Display(Name = "IDКатегории")]
        public int CategoryId { get; set; }

        [Display(Name = "Категория-Ссылочное свойство")]
        public Category Category { get; set; }
    }
}
