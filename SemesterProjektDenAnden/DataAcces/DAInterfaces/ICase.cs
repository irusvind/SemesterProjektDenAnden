﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.DAInterfaces
{
    public interface ICase
    {
        Task<bool> Create(Case newCase);

        Task<bool> Delete(int id);

        Task<List<Case>> GetAll();

        Task<Case> Get(int id);

        Task<bool> Update(Case newCase);
    }
}