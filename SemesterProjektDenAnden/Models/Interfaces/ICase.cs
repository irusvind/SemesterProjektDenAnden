using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface ICase
    {
        public Task<bool> CreateAsync(Case newCase);

        public Task<bool> DeleteAsync(int id);

        public Task<List<Case>> GetAllAsync();

        public Task<Case> GetAsync(int id);

        public Task<bool> UpdateAsync(Case newCase);

        public Task<List<Case>> GetCaseWithClientIdAsync(int id);
    }
}
