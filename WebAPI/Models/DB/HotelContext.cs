using Hotel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebAPI.Models.DB {
    public class HotelContext: DbContext {
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            string conn = "server=localhost;database=hotelverwaltung;user=root;password='';Convert Zero Datetime=True";
            builder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Room>()
                .Property(r => r.nightPrice)
                .HasPrecision(14, 2);

            modelBuilder.Entity<Room>()
                .HasKey(r => new { r.number });
        }
    }
}
