﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.PictureUrl).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Price).IsRequired().HasColumnType("desimal(18,2)");
        builder.HasOne(x => x.ProductBrand).WithMany().HasForeignKey(x => x.ProductBrandId);
        builder.HasOne(x => x.ProductType).WithMany().HasForeignKey(x => x.ProductTypeId);
        builder.Property(x => x.Description).HasMaxLength(500);
        builder.Property(x => x.Title).HasMaxLength(100);
        builder.Property(x => x.Summary).HasMaxLength(100);
        builder.Property(x => x.ProductBrandId).IsRequired();
        builder.Property(x => x.ProductTypeId).IsRequired();
    }
}
