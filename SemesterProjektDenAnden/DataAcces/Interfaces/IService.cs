using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public interface IService
    {
        Task<List<Service>> GetAllAsync();

        Task<Service> GetAsync(int id);

        Task<bool> CreateAsync(Service newService);

        Task<bool> UpdateAsync(Service newService);

        Task<bool> DeleteAsync(int id);
    }
}
