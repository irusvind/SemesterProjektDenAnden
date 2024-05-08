using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.DAInterfaces
{
    public interface IWorkLog
    {
        Task<bool> CreateAsync(WorkLog newWorkLog);

        Task<bool> DeleteAsync(int id);

        Task<List<WorkLog>> GetAllAsync();

        Task<WorkLog> GetAsync(int id);

        Task<bool> UpdateAsync(WorkLog newWorkLog);
    }
}
