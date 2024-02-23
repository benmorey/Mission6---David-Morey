using System.ComponentModel.DataAnnotations;

namespace Mission6___David_Morey.Models
{
    //This makes the row for the table 'Collection' from CollectionContext.cs
    public class Collection
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        //Allows the last three rows to be NULL
        public string? Edited { get; set; }
        public string? LentTo { get; set; }
        public int CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}
