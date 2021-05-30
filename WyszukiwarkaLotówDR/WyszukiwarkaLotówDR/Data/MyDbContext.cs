using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Models;

namespace WyszukiwarkaLotówDR.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        
        public DbSet<LotModel> LotyModel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LotModel>().HasData(
            new LotModel(1, Przewoznik.LOT, DateTime.Now.AddDays(31), DateTime.Now.AddDays(32), "Wrocław", "Istambuł", "WRO", "IST", 459, 150),
            new LotModel(2, Przewoznik.EnterAir, DateTime.Now.AddDays(30), DateTime.Now.AddDays(30), "Kalisz", "Istambuł", "WRO", "IST", 451, 150),
            new LotModel(3, Przewoznik.Ryanair, DateTime.Now.AddDays(29), DateTime.Now.AddDays(29), "Szczecin", "Barcelona", "WRO", "IST", 452, 150),
            new LotModel(4, Przewoznik.Ryanair, DateTime.Now.AddDays(32), DateTime.Now.AddDays(32), "Wrocław", "Barcelona", "WRO", "IST", 453, 150),
            new LotModel(5, Przewoznik.Ryanair, DateTime.Now.AddDays(32), DateTime.Now.AddDays(32), "Kalisz", "Barcelona", "WRO", "IST", 453, 150),
            new LotModel(6, Przewoznik.LOT, DateTime.Now.AddDays(34), DateTime.Now.AddDays(34), "Szczecin", "Barcelona", "WRO", "IST", 453, 150),
            new LotModel(7, Przewoznik.TurkishAirlines, DateTime.Now.AddDays(31), DateTime.Now.AddDays(31), "Warszawa", "Alanya", "WAR", "ALN", 560, 210),
            new LotModel(8, Przewoznik.TurkishAirlines, DateTime.Now.AddDays(31), DateTime.Now.AddDays(31), "Berlin", "Istambuł", "BER", "IST", 460, 200),
            new LotModel(9, Przewoznik.LOT, DateTime.Now.AddDays(31), DateTime.Now.AddDays(31), "Warszawa", "Gdańsk", "WAR", "GDA", 160, 10),
            new LotModel(10, Przewoznik.Ryanair, DateTime.Now.AddDays(32), DateTime.Now.AddDays(32), "Warszawa", "Moskwa", "WAR", "MSK", 760, 110)

             );
        }
    }
}
