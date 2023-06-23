using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Category
    {
        [Key]//optional to be primary key in the table
        public int Id { get; set; }
        [Required]//
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}
