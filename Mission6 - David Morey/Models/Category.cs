using System.ComponentModel.DataAnnotations;

namespace Mission6___David_Morey.Models
{
    public class Category
    {
        [Key]   
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
