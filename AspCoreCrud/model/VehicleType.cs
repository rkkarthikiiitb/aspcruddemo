using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;

namespace AspCoreCrud.model
{
    public class VehicleType
    {
        public short Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public VehicleType()
        {
            Vehicles = new Collection<Vehicle>();
        }
    }
}
