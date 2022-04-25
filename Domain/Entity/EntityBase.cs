using System.ComponentModel.DataAnnotations;

namespace HikikomoriWEB.Domain.Entity
{
    public abstract class EntityBase //базовый класс для доменной модели
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Название")]
        public virtual string Name { get; set; }

        [Display(Name = "SEO Title")]
        public string MetaTitle { get; set; }
    }
}
