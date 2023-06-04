using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Map.Options
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {  
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).HasColumnName("Oluşturma Tarihi");
            builder.Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
            builder.Property(x => x.ModifiedDate).HasColumnName("Güncelleme Tarihi");
            builder.Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
