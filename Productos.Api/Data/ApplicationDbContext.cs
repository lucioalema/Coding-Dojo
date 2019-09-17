using Microsoft.EntityFrameworkCore;
using Productos.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Api.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                 : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Products>().HasData(
                new Products()
                {
                    Id = 1,
                    Account = "444444444",
                    Category = Category.CajaAhorro,
                    StartDate = DateTime.Now                   
                }
                );
        }


    }
}
