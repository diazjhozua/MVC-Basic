using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MahikapeWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]

   
        public string? Name { get; set; }

        [DisplayName("Display Order")]

        [RangeAttribute(1,100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
