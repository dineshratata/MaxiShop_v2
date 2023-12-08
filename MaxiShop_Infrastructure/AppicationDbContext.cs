using MaxiShop.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaxiShop_Infrastructure
{
   
    public class ApplicationDbContext : DbContext 
    {
    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) {
        }

        public DbSet <Category> categories { get; set; }
      
    }


}