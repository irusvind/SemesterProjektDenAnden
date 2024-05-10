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
    public class CaseBL : ICaseBL
    {
        CaseDA CaseDA = new CaseDA();

        public async Task<bool> CreateAsync(Case newCase)
        {
            bool result = await CaseDA.CreateAsync(newCase);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool result = await CaseDA.DeleteAsync(id);
            return result;
        }

        public async Task<List<Case>> GetAllAsync()
        {
            List<Case> cases = await CaseDA.GetAllAsync();
            return cases;
        }

        public async Task<Case> GetAsync(int id)
        {
            Case selectedCase = await CaseDA.GetAsync(id);
            return selectedCase;
        }

        public async Task<bool> UpdateAsync(Case newCase)
        {
            bool result = await CaseDA.UpdateAsync(newCase);
            return result;
        }

        public async Task<List<Case>> GetCaseWithClientIdAsync(int id)
        {
            List<Case> clientCases = await CaseDA.GetCaseWithClientIdAsync(id);
            return clientCases;
        }
    }
}
