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
    public class CustomerMap : BaseMap<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.ToTable("Müşteriler");
            builder.Property(x => x.Username).HasColumnName("Kullanıcı Adı");
            builder.Property(x => x.Password).HasColumnName("Şifre");
            builder.Property(x => x.FirstName).HasColumnName("Ad");
            builder.Property(x => x.LastName).HasColumnName("Soyad");
            builder.Property(x => x.Email).HasColumnName("Mail Adresi");
            builder.Property(x => x.Phone).HasColumnName("Telefon Numarası");
            builder.Property(x => x.IdentityNo).HasColumnName("Tc Kimlik Numarası");
            builder.Property(x => x.Address).HasColumnName("Adres");
            builder.Property(x => x.Gender).HasColumnName("Cinsiyet");
            builder.Property(x => x.DriverLicenseNumber).HasColumnName("Ehliyet Numarası");
        }
    }
}
