using MaxiShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace MaxiShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {





        }

        public ApplicationDbContext()
        {


        }

          public DbSet<Category> categories { get; set; } 

    }


}
