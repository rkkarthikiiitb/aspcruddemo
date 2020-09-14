using System;
namespace AspCoreCrud.Controllers.Resources
{
    public class SaveVehicleResource
    {
        public int Id { get; set; }
        public short VehicleTypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
