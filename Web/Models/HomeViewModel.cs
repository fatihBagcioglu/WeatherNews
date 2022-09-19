using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class HomeViewModel
    {
        [Required]
        public string Place { get; set; } = null!;
        public decimal? Temperature { get; set; }

    }
}
