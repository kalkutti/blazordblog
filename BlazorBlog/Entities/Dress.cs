using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace BlazorBlog.Entities
{
    public class Dress
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = "jkl";
        public Color Color { get; set; } = Color.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
