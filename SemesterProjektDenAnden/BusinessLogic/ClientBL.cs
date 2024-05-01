using DataAcces.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class ClientBL : IClient
    {
        public Task<bool> CreateAsync(Client newClient)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Client newClient)
        {
            throw new NotImplementedException();
        }
    }
}
