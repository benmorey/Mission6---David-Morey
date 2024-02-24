using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6___David_Morey.Models
{
    //This makes the columns for the table 'Collection' from CollectionContext.cs
    public class Movies
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category {  get; set; }
        [Required(ErrorMessage = "You need to input the title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You need to input a proper year")]
        public int Year { get; set; } = 2024;
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "You need to record if it was edited or not")]
        public int Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "You need to record if it was copied in Plex or not")]
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
