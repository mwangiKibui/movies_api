global using Microsoft.EntityFrameworkCore;
global using Movies.Data;
global using Movies.Models;
using Movies.Services.Movies;
using Pomelo.EntityFrameworkCore.MySql;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add the database connection.
builder.Services.AddDbContext<DataContext>(opt => opt.UseMySql(builder.Configuration.GetConnectionString("ConnectionString"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("ConnectionString"))));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMovieService,MovieService>();
var app = builder.Build();

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

