using HikikomoriWEB.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HikikomoriWEB.MVC.Models
{
    public class Category : EntityBase
    {
        [Required]
        [Display(Name = "Название категории")]
        public override string Name{ get; set; }

        
        //public List<Content> Content { get; set; } // контент относящийся к нужной категории
    }
}
