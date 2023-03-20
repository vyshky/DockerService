using CloudDbTestSPD011.Model;
using Microsoft.EntityFrameworkCore;
using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.ClientService
{
    public class DbDaoClient : IDaoClient
    {
        private readonly ApplicationDbContext _context;

        public DbDaoClient(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Client> AddAsync(Client client)
        {
            await _context.Client.AddAsync(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<List<Client>> GetAllAsync()
        {
            List<Client> clients = await _context.Client.ToListAsync();
            await _context.SaveChangesAsync();
            return clients;
        }

        // Not Implemented methods
        public async Task<Client> DeleteAsync(int id)
        {
            Client client = await _context.Client.SingleOrDefaultAsync(x => x.Id == id);
            _context.Remove(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client> GetAsync(int id)
        {
            Client client = await _context.Client.SingleOrDefaultAsync(x => x.Id == id);
            return client;
        }

        public async Task<Client> UpdateAsync(Client client)
        {
            _context.Client.Update(client);
            await _context.SaveChangesAsync();
            return client;
        }
    }
}
