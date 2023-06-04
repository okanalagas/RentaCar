using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentaCar.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Map.Options
{
    public class CarMap : BaseMap<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            base.Configure(builder);
            builder.ToTable("Araçlar");
            builder.Property(x => x.Brand).HasColumnName("Marka");
            builder.Property(x => x.Model).HasColumnName("Model");
            builder.Property(x => x.Description).HasColumnName("Açıklama");
            builder.Property(x => x.ModelYear).HasColumnName("Model Yılı");
            builder.Property(x => x.TransmissionType).HasColumnName("Vites Tipi");
            builder.Property(x => x.FuelType).HasColumnName("Yakıt Tipi");
            builder.Property(x => x.Km).HasColumnName("Km");
            builder.Property(x => x.Seat).HasColumnName("Koltuk Sayısı");
            builder.Property(x => x.isRented).HasColumnName("Kirada mı");
            builder.Property(x => x.Image).HasColumnName("Resim Adresi");
            builder.Property(x => x.Rental).HasColumnName("Kiralama Ücreti");
        }
    }
}
