using CloudDbTestSPD011.Model;
using OrdersApiAppSPD011.Model.Entity;
using OrdersApiAppSPD011.Service.ClientService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddTransient<IDaoClient, DbDaoClient>();

var app = builder.Build();

app.MapGet("/ping", () => new { Time = DateTime.Now, Message = "pong" });


// обработчики тестирования бизнес-логики для работы с клиентом
app.MapGet("/client/all", async (IDaoClient daoClient) =>
{
    return await daoClient.GetAllAsync();
});

app.MapPost("/client/add", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.AddAsync(client);
});

app.MapPost("/client/remove", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.DeleteAsync(client.Id);
});

app.MapPost("/client/find", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.GetAsync(client.Id);
});

app.MapPost("/client/update", async (Client client, IDaoClient daoClient) =>
{
    return await daoClient.UpdateAsync(client);
});

app.Run();
