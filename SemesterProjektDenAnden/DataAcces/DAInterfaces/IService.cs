using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.DAInterfaces
{
    public interface IService
    {
        Task<List<Service>> GetAllAsync();

        Task<Service> GetAsync(int id);

        Task<bool> DeleteAsync(int id);

        Task UpdateServicesAsync(int serviceId, int caseId);

        Task<List<Service>> GetSpecificCaseServiceAsync(int caseId);
    }
}
