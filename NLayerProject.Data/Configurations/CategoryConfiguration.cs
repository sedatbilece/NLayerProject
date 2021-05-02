﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
     
        public void Configure(EntityTypeBuilder<Category> builder)
        {


            builder.ToTable("Categories");// table name

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            
        }
    }
}
