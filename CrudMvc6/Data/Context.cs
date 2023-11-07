using Microsoft.EntityFrameworkCore;

namespace CrudMvc6.Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions options) : base(options) 
        {
           
        }
       public DbSet<Product> products { get; set; }
    }
}
