using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public interface ICourse
    {
        List<Course> GetAll();

        Course Get(int id);

        bool Create(Course newCourse);

        bool Update(Course newCourse);

        bool Delete(int id);
    }
}
