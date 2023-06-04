using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentaCar.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Araçlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelYılı = table.Column<int>(name: "Model Yılı", type: "int", nullable: false),
                    VitesTipi = table.Column<string>(name: "Vites Tipi", type: "nvarchar(max)", nullable: false),
                    YakıtTipi = table.Column<string>(name: "Yakıt Tipi", type: "nvarchar(max)", nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    KoltukSayısı = table.Column<int>(name: "Koltuk Sayısı", type: "int", nullable: false),
                    Kiradamı = table.Column<bool>(name: "Kirada mı", type: "bit", nullable: false),
                    ResimAdresi = table.Column<string>(name: "Resim Adresi", type: "nvarchar(max)", nullable: false),
                    KiralamaÜcreti = table.Column<decimal>(name: "Kiralama Ücreti", type: "money", nullable: false),
                    OluşturmaTarihi = table.Column<DateTime>(name: "Oluşturma Tarihi", type: "datetime2", nullable: false),
                    GüncellemeTarihi = table.Column<DateTime>(name: "Güncelleme Tarihi", type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(name: "Silme Tarihi", type: "datetime2", nullable: true),
                    VeriDurumu = table.Column<int>(name: "Veri Durumu", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araçlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Müşteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullanıcıAdı = table.Column<string>(name: "Kullanıcı Adı", type: "nvarchar(max)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdresi = table.Column<string>(name: "Mail Adresi", type: "nvarchar(max)", nullable: false),
                    TelefonNumarası = table.Column<string>(name: "Telefon Numarası", type: "nvarchar(max)", nullable: false),
                    TcKimlikNumarası = table.Column<long>(name: "Tc Kimlik Numarası", type: "bigint", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: true),
                    EhliyetNumarası = table.Column<string>(name: "Ehliyet Numarası", type: "nvarchar(max)", nullable: false),
                    OluşturmaTarihi = table.Column<DateTime>(name: "Oluşturma Tarihi", type: "datetime2", nullable: false),
                    GüncellemeTarihi = table.Column<DateTime>(name: "Güncelleme Tarihi", type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(name: "Silme Tarihi", type: "datetime2", nullable: true),
                    VeriDurumu = table.Column<int>(name: "Veri Durumu", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Müşteriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Siparişler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MüşteriId = table.Column<int>(name: "Müşteri Id", type: "int", nullable: false),
                    AraçId = table.Column<int>(name: "Araç Id", type: "int", nullable: false),
                    AraçAlımOfisi = table.Column<string>(name: "Araç Alım Ofisi", type: "nvarchar(max)", nullable: false),
                    AraçTeslimOfisi = table.Column<string>(name: "Araç Teslim Ofisi", type: "nvarchar(max)", nullable: false),
                    AraçAlımTarihi = table.Column<DateTime>(name: "Araç Alım Tarihi", type: "datetime2", nullable: false),
                    AraçTeslimTarihi = table.Column<DateTime>(name: "Araç Teslim Tarihi", type: "datetime2", nullable: false),
                    ToplamKiralamaTutarı = table.Column<decimal>(name: "Toplam Kiralama Tutarı", type: "money", nullable: false),
                    OluşturmaTarihi = table.Column<DateTime>(name: "Oluşturma Tarihi", type: "datetime2", nullable: false),
                    GüncellemeTarihi = table.Column<DateTime>(name: "Güncelleme Tarihi", type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(name: "Silme Tarihi", type: "datetime2", nullable: true),
                    VeriDurumu = table.Column<int>(name: "Veri Durumu", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparişler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siparişler_Araçlar_Araç Id",
                        column: x => x.AraçId,
                        principalTable: "Araçlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparişler_Müşteriler_Müşteri Id",
                        column: x => x.MüşteriId,
                        principalTable: "Müşteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Siparişler_Araç Id",
                table: "Siparişler",
                column: "Araç Id");

            migrationBuilder.CreateIndex(
                name: "IX_Siparişler_Müşteri Id",
                table: "Siparişler",
                column: "Müşteri Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Siparişler");

            migrationBuilder.DropTable(
                name: "Araçlar");

            migrationBuilder.DropTable(
                name: "Müşteriler");
        }
    }
}
