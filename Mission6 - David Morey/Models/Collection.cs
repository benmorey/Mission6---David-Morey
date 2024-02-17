using System.ComponentModel.DataAnnotations;

namespace Mission6___David_Morey.Models
{
    //This makes the row for the table 'Collection' from CollectionContext.cs
    public class Collection
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        //Allows the last three rows to be NULL
        public string? Edited { get; set; }
        public string? Lent { get; set; }
        public string? Notes { get; set; }
    }
}
