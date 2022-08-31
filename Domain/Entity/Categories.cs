using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HikikomoriWEB.Domain.Entity
{
    public class Categories
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название категории")]
        public string Name { get; set; }

        [Display(Name = "Навигация коллекции")]
        public List<RateContent> Contents { get; set; }
    }
}
