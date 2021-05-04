using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Configurations
{

    // config file extending 
    class ProductConfiguration : IEntityTypeConfiguration<Category>
    {

        // interface implemeting
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.ToTable("Products");// table name

            builder.HasKey(x => x.Id);// id is primary key

            builder.Property(x => x.Id).UseIdentityColumn();// 

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);// name required and max 200 char

            builder.Property(x => x.Stock).IsRequired();

            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");// price is like as 14552236.50 

            builder.Property(x => x.InnerBarcode).HasMaxLength(50);

        }
    }
}
