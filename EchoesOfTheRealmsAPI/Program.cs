using EotR.App.Services;
using EotR.Infra.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EotRContext>(b => b.UseSqlServer("workstation id=EchoesOfTheRealms.mssql.somee.com;packet size=4096;user id=Hakuryu_SQLLogin_1;pwd=vgndzvm882;data source=EchoesOfTheRealms.mssql.somee.com;persist security info=False;initial catalog=EchoesOfTheRealms;TrustServerCertificate=True"));

//Ajout du service venant de l'app externe
builder.Services.AddScoped<ClasseTest>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseAuthorization();

app.MapControllers();

app.Run();
