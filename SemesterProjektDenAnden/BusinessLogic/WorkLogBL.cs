using DataAcces;
using Models;
using Models.Interfaces;

namespace BusinessLogic
{
    public class WorkLogBL : IWorkLog
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

        public async Task<List<WorkLog>> GetAllAsync(int id)
        {
            List<WorkLog> workLogs = await workLogDA.GetAllAsync(id);
            return workLogs;
        }

        public async Task<bool> UpdateAsync(WorkLog newWorkLog)
        {
            bool result = await workLogDA.UpdateAsync(newWorkLog);
            return result;
        }
    }
}
