using System;
using AspCoreCrud.model;
using Microsoft.EntityFrameworkCore;

namespace AspCoreCrud.Persistence
{
    public class VehicleManagementDbContext : DbContext
    {
        public VehicleManagementDbContext(DbContextOptions<VehicleManagementDbContext> options)
            : base(options)
        {

        }
        
        public DbSet<VehicleType> VehicleTypes { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }



    }
}
