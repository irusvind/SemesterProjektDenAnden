using BusinessLogic.BLInterfaces;
using DataAcces;
using DataAcces.DAInterfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CourseBL : ICourseBL
    {
        CourseDA courseDA = new CourseDA();
        public async Task<bool> CreateAsync(Course newCourse)
        {
            bool result = await courseDA.CreateAsync(newCourse);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool result = await courseDA.DeleteAsync(id);
            return result;
        }

        public async Task<List<Course>> GetAllAsync()
        {
            List<Course> result = await courseDA.GetAllAsync();
            return result;
        }

        public async Task<Course> GetAsync(int id)
        {
            Course course = await courseDA.GetAsync(id);
            return course;
        }

        public async Task<bool> UpdateAsync(Course newCourse)
        {
            bool result = await courseDA.UpdateAsync(newCourse);
            return result;
        }
    }
}
