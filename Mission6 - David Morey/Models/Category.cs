
//This file creates the columns within the Category Table

using System.ComponentModel.DataAnnotations;

namespace Mission6___David_Morey.Models
{
    public class Category
    {
        [Required]
        [Key]   
        public int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; }//The type of film it is. Ex: Action, Mystery, etc.
    }
}
