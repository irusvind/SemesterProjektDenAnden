using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLInterfaces
{
    public interface IEmployeeBL
    {
        Task<bool> CreateAsync(Employee employee);

        Task<bool> DeleteAsync(Employee employee);

        Task<List<Employee>> GetAllAsync();

        Task<Employee> GetAsync(int id);

        Task<bool> UpdateAsync(Employee employee);
    }
}
