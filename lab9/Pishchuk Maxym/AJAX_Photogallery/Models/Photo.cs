using System.ComponentModel.DataAnnotations;

namespace AJAX_Photogallery.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Link { get; set; }
    }
}
