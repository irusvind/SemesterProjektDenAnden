using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IService
    {
        Task<List<Service>> GetAllAsync();

        Task<Service> GetAsync(int id);

        Task<bool> DeleteAsync(int id);

        Task UpdateAsync(int serviceId, int caseId);

        Task<List<Service>> GetSpecificCaseServiceAsync(int caseId);
    }
}
