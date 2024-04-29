using DataAcces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public interface IClient
    {
        List<Client> GetAll();

        Client Get(int id);

        bool Create(Client newClient);

        bool Update(Client newClient);

        bool Delete(int id);

    }
}

