using AspCoreCrud.Controllers.Resources;
using AspCoreCrud.model;
using AutoMapper;
using System;
namespace AspCoreCrud.Mapper
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            
            CreateMap<VehicleType, KeyValuePairResource>();
            CreateMap<Vehicle, VehicleResource>();

            CreateMap<Car, CarResource>();
               
            CreateMap<Vehicle, SaveVehicleResource>();
            CreateMap<Car, SaveCarResource>();

            //Api resource to Domain
            CreateMap<SaveVehicleResource, Vehicle>();
            CreateMap<SaveCarResource, Car>();

        }
    }
}
