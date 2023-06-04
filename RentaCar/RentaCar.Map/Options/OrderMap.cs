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
    public class OrderMap: BaseMap<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.ToTable("Siparişler");
            builder.Property(x => x.CustomerId).HasColumnName("Müşteri Id");
            builder.Property(x => x.CarId).HasColumnName("Araç Id");
            builder.Property(x => x.PickUpOffice).HasColumnName("Araç Alım Ofisi");
            builder.Property(x => x.DropOffOffice).HasColumnName("Araç Teslim Ofisi");
            builder.Property(x => x.PickUpDate).HasColumnName("Araç Alım Tarihi");
            builder.Property(x => x.DropOffDate).HasColumnName("Araç Teslim Tarihi");
            builder.Property(x => x.TotalRental).HasColumnName("Toplam Kiralama Tutarı");
        }        
    }
}
