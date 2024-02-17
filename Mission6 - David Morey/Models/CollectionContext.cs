using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Mission6___David_Morey.Models
{
    //Where the magic happens
    public class CollectionContext : DbContext
    {
        public CollectionContext(DbContextOptions<CollectionContext> options) : base(options) //Constructor to make the database
        { }

        public DbSet<Collection> Collection { get; set; } //Making a table within the database
    }
}
