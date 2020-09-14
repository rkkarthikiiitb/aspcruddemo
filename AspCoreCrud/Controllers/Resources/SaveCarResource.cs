using System;
namespace AspCoreCrud.Controllers.Resources
{
    public class SaveCarResource : SaveVehicleResource
    {
        public string Engine { get; set; }
        public string BodyType { get; set; }
        public int Door { get; set; }
        public int Wheel { get; set; }
    }
}
