using System;
namespace AspCoreCrud.model
{
    public class Car : Vehicle
    {
        public string Engine { get; set; }
        public int Door { get; set; }
        public int Wheel { get; set; }
        public string BodyType { get; set; }
    }
}
