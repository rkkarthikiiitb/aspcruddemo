using System;
namespace AspCoreCrud.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public KeyValuePairResource vehicleType { get; set; }
    }
}
