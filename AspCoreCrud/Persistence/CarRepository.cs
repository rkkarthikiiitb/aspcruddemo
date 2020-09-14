using System;
using System.Threading.Tasks;
using AspCoreCrud.CoreInterfaces;
using AspCoreCrud.model;
using Microsoft.EntityFrameworkCore;

namespace AspCoreCrud.Persistence
{
    public class CarRepository : IVehicleRepository<Car>
    {
        private readonly VehicleManagementDbContext context;

        public CarRepository(VehicleManagementDbContext context)
        {
            this.context = context;
        }
        public async Task<Car> GetVehicle(int id)
        {
            return await context.Cars
                           .Include(v => v.vehicleType)
                           .SingleOrDefaultAsync(v => v.Id == id);


        }

        public void AddVehicle(Car car)
        {
            context.Cars.Add(car);
        }

    }
}
