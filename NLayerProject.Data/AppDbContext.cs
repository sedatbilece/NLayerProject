
using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data
{
    class AppDbContext :DbContext
    {
        // base options is switcher to db type  sql ,mysql or something
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        {
                
        }


        // for database table 
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> prudocts { get; set; }


        // tables options here  while creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
