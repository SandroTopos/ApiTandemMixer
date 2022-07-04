using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPITandemMixer.Context;
using WebAPITandemMixer.Controllers;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// For Entity Framework
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Data Source=ADMSQL01PCAM\\ADM01;Initial Catalog=TandemMixer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

//// For Identity -  Essa classes seta/Atende para as Class para IdentityUser 
//builder.Services.AddIdentity<PhasesController,CompoundController>()
//.AddEntityFrameworkStores<AppDbContext>()
//.AddDefaultTokenProviders();

builder.Services.AddIdentity<PhasesController, CompoundController>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();


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
