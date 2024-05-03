using DataAcces;
using BusinessLogic.BLInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.DAInterfaces;

namespace BusinessLogic
{
    internal class ClientBL : IClientBL
    {
        IClientDA clientDA = new ClientDA();

        public async Task<bool> CreateAsync(Client newClient)
        {
            await clientDA.CreateAsync(newClient);
            return true;
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
