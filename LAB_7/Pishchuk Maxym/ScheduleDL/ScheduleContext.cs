using ScheduleDL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDL
{
    public class ScheduleContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>()
            .Property(t => t.ArivalTime)
            .HasColumnType("datetime2");
            modelBuilder.Entity<Schedule>()
            .Property(t => t.DepartureTime)
            .HasColumnType("datetime2");
        }
    }
}
