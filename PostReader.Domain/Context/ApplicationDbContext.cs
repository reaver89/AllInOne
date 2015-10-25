using System.Data.Entity;

namespace PostReader.Data.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext():base("DefaultConnection")
        {
            
        }
    }
}
