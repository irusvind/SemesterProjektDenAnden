﻿using DataAcces;
using Models;
using Models.Interfaces;


namespace BusinessLogic
{
    public class ClientBL : IClient
    {
        ClientDA clientDA = new ClientDA();

        public async Task<bool> CreateAsync(Client newClient)
        {
            bool result = await clientDA.CreateAsync(newClient);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            bool result = await clientDA.DeleteAsync(id);
            return result;
        }

        public async Task<List<Client>> GetAllAsync()
        {
            List<Client> clients = await clientDA.GetAllAsync();
            return clients;
        }

        public async Task<Client> GetAsync(int id)
        {
            Client client = await clientDA.GetAsync(id);
            return client;
        }

        public async Task<bool> UpdateAsync(Client newClient)
        {
            bool result = await clientDA.UpdateAsync(newClient);
            return result;
        }
    }
}
