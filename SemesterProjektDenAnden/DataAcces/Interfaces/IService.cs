using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public interface IService
    {
        List<Service> GetAll();

        Service Get(int id);

        bool Create(Service newService);

        bool Update(Service newService);

        bool Delete(int id);
    }
}
