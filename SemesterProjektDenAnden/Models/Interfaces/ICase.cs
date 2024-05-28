using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface ICase
    {
        Task<bool> CreateAsync(Case newCase);

        Task<bool> DeleteAsync(int id);

        Task<List<Case>> GetAllAsync();

        Task<Case> GetAsync(int id);

        Task<bool> UpdateAsync(Case newCase);

        Task<List<Case>> GetCaseWithClientIdAsync(int id);
    }
}
