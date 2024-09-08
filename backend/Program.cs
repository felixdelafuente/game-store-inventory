using backend.Data;
using backend.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connString = "DefaultConnection";
builder.Services.AddSqlServer<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
