using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.DAInterfaces
{
    public interface ITransportLog
    {
        Task<bool> CreateAsync(TransportLog transport);

        Task<bool> DeleteAsync(int id);

        Task<List<TransportLog>> GetAllAsync(int id);

        Task<TransportLog> GetAsync(int id);

        Task<bool> UpdateAsync(TransportLog transportLog);
    }
}
