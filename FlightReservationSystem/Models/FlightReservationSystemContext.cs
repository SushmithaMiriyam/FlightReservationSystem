using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FlightReservationSystem.Models
{
    public class FlightReservationSystemContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FlightReservationSystemContext() : base("FlightReservationSystemContext")
        {
        }

        public DbSet<Flight> Flight { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Payment> Payment { get; set; }

        //public System.Data.Entity.DbSet<FlightReservationSystem.Models.Flight> Flight { get; set; }
        //public System.Data.Entity.DbSet<FlightReservationSystem.Models.Schedule> Schedule { get; set; }
        //public System.Data.Entity.DbSet<FlightReservationSystem.Models.Ticket> Ticket { get; set; }
        //public System.Data.Entity.DbSet<FlightReservationSystem.Models.Payment> Payment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
