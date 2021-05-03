using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seeds
    // seeds are while creating table adding to table data (mean default data)
{
    class ProductSeed : IEntityTypeConfiguration<Product>
    {

        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }


        // codes in here 
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "pilot kalem", Price = 12.5m, Stock = 350, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "kusun kalem", Price = 3m, Stock = 50, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "k defter", Price = 2.5m, Stock = 150, CategoryId = _ids[1] },
                new Product { Id = 4, Name = "b defter kalem", Price = 4.5m, Stock = 150, CategoryId = _ids[1] }
                );
        }
    }
}
