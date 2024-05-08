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
    public class WorkLogBL : IWorkLogBL
    {
        WorkLogDA workLogDA = new WorkLogDA();
        public async Task<bool> CreateAsync(WorkLog newWorkLog)
        {
           bool result = await workLogDA.CreateAsync(newWorkLog);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool result = await workLogDA.DeleteAsync(id);
            return result;
        }

        public async Task<WorkLog> GetAsync(int id)
        {
            WorkLog workLog = await workLogDA.GetAsync(id);
            return workLog;
        }

        public async Task<List<WorkLog>> GetAllAsync()
        {
            List<WorkLog> workLogs = await workLogDA.GetAllAsync();
            return workLogs;
        }

        public async Task<bool> UpdateAsync(WorkLog newWorkLog)
        {
            bool result = await workLogDA.UpdateAsync(newWorkLog);
            return result;
        }
    }
}
