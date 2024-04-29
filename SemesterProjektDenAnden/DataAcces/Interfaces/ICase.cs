using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Interfaces
{
    public interface ICase
    {
        List<Case> GetAll();

        Case Get(int id);

        bool Create(Case newCase);

        bool Update(Case newCase);

        bool Delete(int id);
    }
}
