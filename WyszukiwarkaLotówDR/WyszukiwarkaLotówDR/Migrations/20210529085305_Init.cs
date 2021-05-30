using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WyszukiwarkaLotówDR.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotyModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Przewoznik = table.Column<int>(type: "int", nullable: false),
                    czasWylotu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    czasPrzylotu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    miejsceWylotu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    miejscePrzylotu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kodLotniskaWylotu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kodLotniskaPrzylotu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cenaBiletu = table.Column<double>(type: "float", nullable: false),
                    iloscMiejsc = table.Column<int>(type: "int", nullable: false),
                    Obraz = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotyModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LotyModel",
                columns: new[] { "Id", "Obraz", "Przewoznik", "cenaBiletu", "czasPrzylotu", "czasWylotu", "iloscMiejsc", "kodLotniskaPrzylotu", "kodLotniskaWylotu", "miejscePrzylotu", "miejsceWylotu" },
                values: new object[,]
                {
                    { 1, "LOT.png", 2, 459.0, new DateTime(2021, 6, 30, 10, 53, 4, 477, DateTimeKind.Local).AddTicks(8544), new DateTime(2021, 6, 29, 10, 53, 4, 467, DateTimeKind.Local).AddTicks(8591), 150, "IST", "WRO", "Istambuł", "Wrocław" },
                    { 2, "EnterAir.png", 1, 451.0, new DateTime(2021, 6, 28, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2330), new DateTime(2021, 6, 28, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2243), 150, "IST", "WRO", "Istambuł", "Kalisz" },
                    { 3, "Ryanair.png", 0, 452.0, new DateTime(2021, 6, 27, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2373), new DateTime(2021, 6, 27, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2366), 150, "IST", "WRO", "Barcelona", "Szczecin" },
                    { 4, "Ryanair.png", 0, 453.0, new DateTime(2021, 6, 30, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2391), new DateTime(2021, 6, 30, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2384), 150, "IST", "WRO", "Barcelona", "Wrocław" },
                    { 5, "Ryanair.png", 0, 453.0, new DateTime(2021, 6, 30, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2404), new DateTime(2021, 6, 30, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2400), 150, "IST", "WRO", "Barcelona", "Kalisz" },
                    { 6, "LOT.png", 2, 453.0, new DateTime(2021, 7, 2, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2418), new DateTime(2021, 7, 2, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2412), 150, "IST", "WRO", "Barcelona", "Szczecin" },
                    { 7, "TurkishAirlines.png", 4, 560.0, new DateTime(2021, 6, 29, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2433), new DateTime(2021, 6, 29, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2427), 210, "ALN", "WAR", "Alanya", "Warszawa" },
                    { 8, "TurkishAirlines.png", 4, 460.0, new DateTime(2021, 6, 29, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2447), new DateTime(2021, 6, 29, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2442), 200, "IST", "BER", "Istambuł", "Berlin" },
                    { 9, "LOT.png", 2, 160.0, new DateTime(2021, 6, 29, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2462), new DateTime(2021, 6, 29, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2456), 10, "GDA", "WAR", "Gdańsk", "Warszawa" },
                    { 10, "Ryanair.png", 0, 760.0, new DateTime(2021, 6, 30, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2477), new DateTime(2021, 6, 30, 10, 53, 4, 480, DateTimeKind.Local).AddTicks(2471), 110, "MSK", "WAR", "Moskwa", "Warszawa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotyModel");
        }
    }
}
