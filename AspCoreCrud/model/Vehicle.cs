using System;
namespace AspCoreCrud.model
{
    public class Vehicle
    {
        public Vehicle()
        {
        }
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public VehicleType vehicleType { get; set; }
        public short VehicleTypeId { get; set; }

    }
}
