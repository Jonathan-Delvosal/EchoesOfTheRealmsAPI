using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.Services;
using EotR.App.Services;
using EotR.App.Utils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(_ =>
{
    HttpClient client = new();
    client.DefaultRequestHeaders.Add("ContentType", "application/json");
    string _API_KEY = builder.Configuration.GetValue<string>("OpenAIApiKeyHaku")!;
    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _API_KEY);
    return client;
});

builder.Services.AddScoped<MonsterService>();
builder.Services.AddScoped<AIService>();
builder.Services.AddScoped<JwtManager>();
builder.Services.AddScoped<UserService>();

builder.Services.AddDbContext<EotRContext>(b => b.UseSqlServer("workstation id=EchoesOfTheRealms.mssql.somee.com;packet size=4096;user id=Hakuryu_SQLLogin_1;pwd=vgndzvm882;data source=EchoesOfTheRealms.mssql.somee.com;persist security info=False;initial catalog=EchoesOfTheRealms;TrustServerCertificate=True"));

//Ajout du service venant de l'app externe
builder.Services.AddScoped<ClasseTest>();

builder.Services.AddCors(b => b.AddDefaultPolicy(o => o.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseAuthorization();

app.MapControllers();

app.Run();
