namespace OrdersApiAppSPD011.Model.Entity
{
    // сущность Клиента
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Client()
        {
            Name = "";
        }
    }
}
