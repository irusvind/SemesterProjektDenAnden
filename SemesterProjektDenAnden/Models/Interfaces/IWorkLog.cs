﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IWorkLog
    {
        Task<bool> CreateAsync(WorkLog newWorkLog);

        Task<bool> DeleteAsync(int id);

        Task<List<WorkLog>> GetAllAsync(int id);

        Task<WorkLog> GetAsync(int id);

        Task<bool> UpdateAsync(WorkLog newWorkLog);
    }
}
