using BusinessLogic.BLInterfaces;
using DataAcces;
using DataAcces.DAInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CaseBL : ICaseBL
    {
        ICase caseDA = new CaseDA();

        public async Task<bool> CreateAsync(Case newCase)
        {
            bool result = await caseDA.CreateAsync(newCase);
            return result;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Case> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Case>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Case newCase)
        {
            throw new NotImplementedException();

        }
    }
}
