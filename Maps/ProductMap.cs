using Clothesstore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothesstore.Maps
{
    public class ProductMap
    {

        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(x => x.product_id);
            entityBuilder.ToTable("products");

            entityBuilder.Property(x => x.product_id).HasColumnName("id");
            entityBuilder.Property(x => x.name).HasColumnName("name");
            entityBuilder.Property(x => x.pictures).HasColumnName("pictures");
            entityBuilder.Property(x => x.price).HasColumnName("price");
            entityBuilder.Property(x => x.rating).HasColumnName("rating");
            entityBuilder.Property(x => x.seller).HasColumnName("seller");
            entityBuilder.Property(x => x.thumbnail).HasColumnName("thumbnail");
            entityBuilder.Property(x => x.brand).HasColumnName("brand");
            entityBuilder.Property(x => x.city).HasColumnName("city");
            entityBuilder.Property(x => x.currency).HasColumnName("currency");
            entityBuilder.Property(x => x.description).HasColumnName("description");
            entityBuilder.Property(x => x.discountPercent).HasColumnName("discountPercent");
            entityBuilder.Property(x => x.discountPrice).HasColumnName("discountPrice");

        }

    }
}
