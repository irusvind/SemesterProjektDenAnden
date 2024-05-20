﻿using BusinessLogic.BLInterfaces;
using DataAcces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    
    public class TransportLogBL : ITransportLogBL
    {
       TransportLogDA transportLogDA = new TransportLogDA();
        public async Task<bool> CreateAsync(TransportLog transport)
        {
            bool result = await transportLogDA.CreateAsync(transport);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool result = await transportLogDA.DeleteAsync(id);
            return result;
        }

        public async Task<TransportLog> GetAsync(int id)
        {
            TransportLog transportLog = await transportLogDA.GetAsync(id);
            return transportLog;
        }

        public async Task<List<TransportLog>> GetAllAsync(int id)
        {
            List<TransportLog> result = await transportLogDA.GetAllAsync(id);
            return result;
        }

        public async Task<bool> UpdateAsync(TransportLog transportLog)
        {
           bool result = await transportLogDA.UpdateAsync(transportLog);
            return result;
        }
    }
}
