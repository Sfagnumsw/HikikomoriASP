using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.Domain.Entity
{
    public abstract class EntityBase //базовый класс для доменной модели
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название")]
        public virtual string Name { get; set; }

        [Display(Name = "SEO Title")]
        public string MetaTitle { get; set; }
    }
}
