using System;
using System.Threading.Tasks;

namespace AspCoreCrud.CoreInterfaces

{
    public interface IVehicleRepository<TVehicle> where TVehicle : model.Vehicle
    {
        Task<TVehicle> GetVehicle(int id);
        void AddVehicle(TVehicle t);
    }
}
