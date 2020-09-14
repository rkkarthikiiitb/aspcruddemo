using System;
using System.Threading.Tasks;
using AspCoreCrud.Controllers.Resources;
using AspCoreCrud.CoreInterfaces;
using AspCoreCrud.model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreCrud.Controllers
{
    [Route("/api/vehicles")]
    public class VehicleController : Controller
    {
        private readonly IMapper mapper;
        private readonly IVehicleRepository<Car> repository;
        private readonly IUnitOfWork unitOfWork;

        public VehicleController(IMapper mapper, IVehicleRepository<Car> repository, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] SaveCarResource vehicleResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicle = mapper.Map<SaveCarResource, Car>(vehicleResource);
            repository.AddVehicle(vehicle);
            await unitOfWork.CompleteAsync();

            vehicle = await repository.GetVehicle(vehicle.Id);
            var result = mapper.Map<Vehicle, CarResource>(vehicle);
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetVehicles(int id)
        {
            var car = await repository.GetVehicle(id);
            if (car == null)
                return NotFound();
            var carResource = mapper.Map<Vehicle, CarResource>(car);
            return Ok(carResource);
        }

    }
}
