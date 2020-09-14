using System;
using System.Threading.Tasks;

namespace AspCoreCrud.CoreInterfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
