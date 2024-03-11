using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Entities
{
    public class Dress
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
