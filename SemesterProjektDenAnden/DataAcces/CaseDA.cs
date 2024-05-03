using DataAcces.DAInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAcces
{
    public class CaseDA : ICase
    {
        public Task<bool> Create(Case newCase)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Case> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Case>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Case newCase)
        {
            throw new NotImplementedException();
        }
    }
}
