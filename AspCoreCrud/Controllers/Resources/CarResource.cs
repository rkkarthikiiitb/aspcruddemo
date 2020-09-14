using System;
namespace AspCoreCrud.Controllers.Resources
{
    public class CarResource : VehicleResource
    {
        public string Engine { get; set; }
        public string BodyType { get; set; }
        public int Door { get; set; }
        public int Wheel { get; set; }
    }
}
