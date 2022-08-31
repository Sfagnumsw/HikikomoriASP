using System.ComponentModel.DataAnnotations;

namespace HikikomoriWEB.Domain.Entity
{
    public class Roles
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Название роли")]
        public string Role { get; set; }
    }
}
