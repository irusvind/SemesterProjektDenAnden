using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.DAInterfaces;
using Models;

namespace DataAcces
{
    public class ServiceDA : IService
    {
        public Task<bool> CreateAsync(Service newService)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Service>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Service> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Service newService)
        {
            throw new NotImplementedException();
        }
    }
}
