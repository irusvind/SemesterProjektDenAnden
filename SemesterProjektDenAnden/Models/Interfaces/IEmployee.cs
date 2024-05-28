using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IEmployee
    {
        Task<bool> CreateAsync(Employee employee);

        Task<bool> DeleteAsync(int id);

        Task<List<Employee>> GetAllAsync();

        Task<Employee> GetAsync(int id);

        Task<bool> UpdateAsync(Employee employee);

    }
}
