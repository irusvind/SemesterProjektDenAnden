using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLInterfaces
{
    internal interface ICourseBL
    {
        Task<bool> CreateAsync(Course newCourse);

        Task<bool> DeleteAsync(int id);

        Task<List<Course>> GetAllAsync();

        Task<Course> GetAsync(int id);

        Task<bool> UpdateAsync(Course newCourse);
    }
}
