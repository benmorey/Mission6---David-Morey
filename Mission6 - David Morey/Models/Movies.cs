using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6___David_Morey.Models
{
    //This makes the row for the table 'Collection' from CollectionContext.cs
    public class Movies
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? CategoryName {  get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        //Allows the last three rows to be NULL
        public int Edited { get; set; }
        public string? LentTo { get; set; }
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
