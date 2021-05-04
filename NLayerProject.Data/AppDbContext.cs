
using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Data.Configurations;
using NLayerProject.Data.Seeds;
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


        // for database table  ...
        public DbSet<Category> categories { get; set; }
        public DbSet<Category> prudocts { get; set; }


        // tables options here  while creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //added tables config file in here
            modelBuilder.ApplyConfiguration( new ProductConfiguration() );

            modelBuilder.ApplyConfiguration( new CategoryConfiguration() );

            modelBuilder.ApplyConfiguration( new ProductSeed(new int[] { 1,2}) );
            modelBuilder.ApplyConfiguration( new CategorySeed(new int[] { 1, 2 }) );

        }

    }
}
