using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.ClientService
{
    // интерфейс DAO для работы с клиентом
    public interface IDaoClient
    {
        // базовый CRUD
        Task<List<Client>> GetAllAsync();
        Task<Client> AddAsync(Client client);
        Task<Client> UpdateAsync(Client client);
        Task<Client> DeleteAsync(int id);
        Task<Client> GetAsync(int id);
    }
}
