using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_Infrastructure.Models
{

  
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {





        }

        public ApplicationDbContext()
        {
        }

        public DbSet<Category> categories { get; set; }

    }


}

}