using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.DAInterfaces;
using Models;

namespace DataAcces
{
    public class CourseDA : ICourse
    {
        public Task<bool> CreateAsync(Course newCourse)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Course newCourse)
        {
            throw new NotImplementedException();
        }
    }
}
