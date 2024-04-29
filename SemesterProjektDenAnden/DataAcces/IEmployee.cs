using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        bool CreateEmployee(Employee employee);
        bool DeleteEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);

    }
}
