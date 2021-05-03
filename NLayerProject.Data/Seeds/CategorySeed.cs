using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seeds
{// info is in product seed
    class CategorySeed : IEntityTypeConfiguration<Product>
    {

        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }



        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasData( new Category{Id = _ids[0], Name = "kalemler"},
                             new Category { Id = _ids[1], Name = "defterler" }
                        
                );

        }
    }
}
