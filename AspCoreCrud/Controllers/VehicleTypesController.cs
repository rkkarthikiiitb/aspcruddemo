﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspCoreCrud.Controllers.Resources;
using AspCoreCrud.model;
using AspCoreCrud.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreCrud.Controllers
{
    public class VehicleTypesController : Controller
    {
        private readonly VehicleManagementDbContext context;
        private readonly IMapper mapper;
        public VehicleTypesController(VehicleManagementDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("api/vehicleTypes")]
        public async Task<IEnumerable<KeyValuePairResource>> GetVehicleTypes()
        {
            var vehicleTypes = await context.VehicleTypes.ToListAsync();
            return mapper.Map<List<VehicleType>, List<KeyValuePairResource>>(vehicleTypes);
        }

    }
}
