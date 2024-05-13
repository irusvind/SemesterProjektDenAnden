using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLInterfaces
{
    public interface ICaseBL
    {
        Task<bool> CreateAsync(Case newCase);

        Task<bool> DeleteAsync(int id);

        Task<List<Case>> GetAllAsync();

        Task<Case> GetAsync(int id);

        Task<bool> UpdateAsync(Case newCase);

        Task<List<Case>> GetCaseWithClientIdAsync(int id);
    }
}
