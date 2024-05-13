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

        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Case> GetAsync(int id)
        {
            Case case_ = await caseDA.GetAsync(id);
                return case_;
        }

        public async Task<List<Case>> GetAllAsync()
        {
            List<Case> result = await caseDA.GetAllAsync();
            return result;
        }

        public async Task<bool> UpdateAsync(Case newCase)
        {
            throw new NotImplementedException();

        }

        public async Task<List<Case>> GetCaseWithClientIdAsync(int id)
        {
            List<Case> clientCases = await caseDA.GetCaseWithClientIdAsync(id);
            return clientCases;
        }
    }
}
