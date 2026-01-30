using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.Services;
using EotR.App.Services;
using EotR.App.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string cString = builder.Configuration.GetConnectionString("DefaultDev");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication().AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
{
    o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateAudience = false,
        ValidateIssuer = false,
        ValidateLifetime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("EchoesOfTheRealms by Haku!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"))
    };
});

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
builder.Services.AddScoped<PCService>();

builder.Services.AddDbContext<EotRContext>(b => b.UseSqlServer(cString));

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
