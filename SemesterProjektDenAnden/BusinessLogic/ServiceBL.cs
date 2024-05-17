using BusinessLogic.BLInterfaces;
using DataAcces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ServiceBL : IServiceBL
    {
        ServiceDA serviceDA = new ServiceDA();
        public async Task<bool> DeleteAsync(int id)
        {
            bool result = await serviceDA.DeleteAsync(id);
            return result;
        }

        public async Task<List<Service>> GetAllAsync()
        {
            List<Service> services = await serviceDA.GetAllAsync();
            return services;
        }

        public async Task<Service> GetAsync(int id)
        {
            Service service = await serviceDA.GetAsync(id);
            return service;
        }

        public async Task UpdateAsync(int serviceID, int caseId)
        {
            await serviceDA.UpdateServicesAsync(serviceID, caseId);
            

        }

        public async Task<List<Service>> GetSpecificCaseServiceAsync(int caseId)
        {
            List<Service> services = await serviceDA.GetSpecificCaseServiceAsync(caseId);
            return services;
            
        }
    }

}
