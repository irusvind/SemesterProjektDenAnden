using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLInterfaces
{
    public interface ITransportLogBL
    {
        Task<bool> CreateAsync(TransportLog transport);

        Task<bool> DeleteAsync(int id);

        Task<List<TransportLog>> GetAllAsync();

        Task<TransportLog> GetAsync(int id);

        Task<bool> UpdateAsync(TransportLog transportLog);
    }
}
