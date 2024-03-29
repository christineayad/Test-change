﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.EntityFramework.Models;

namespace Test.DataAccess.Repository.IRepository
{
    public interface IClientDataAccess
    {
        IEnumerable<ClientStatusVM> GetAllClient(int page, int size, string searchString);
        Client GetById(int id);
        void Add(Client client);
        void Edit(int id, Client client);
        void Remove(Client client);
        void save();
       List<ClientStatusVM> SearchClientByName(string searchterm);

    }
}
