using System.Data.Entity;
using PostReader.Data.Models;

namespace PostReader.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<SocialAccount> SocialAccount { get; set; }

        public ApplicationDbContext():base("DefaultConnection")
        {
            
        }
    }
}
