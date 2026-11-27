using System.ComponentModel.DataAnnotations;

namespace OmnitrixCRUD.Models
{
    public class Alien
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Poder { get; set; } = string.Empty;
    }
}
