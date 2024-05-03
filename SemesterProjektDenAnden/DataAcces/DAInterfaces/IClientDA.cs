using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.DAInterfaces
{
    public interface IClientDA
    {
        Task<bool> CreateAsync(Client newClient);

        Task<bool> DeleteAsync(int id);

        Task<Client> GetAsync(int id);

        Task<List<Client>> GetAllAsync();

        Task<bool> UpdateAsync(Client newClient);

    }
}

