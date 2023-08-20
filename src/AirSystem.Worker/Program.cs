using AirSystem.Database.Contexts;
using AirSystem.Database.Extensions;
using AirSystem.Models.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json");

var connectionString = builder
    .Configuration
    .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AirSystemContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddControllers();
builder.Services.ConfigureProfiles();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.ApplyMigrate();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();