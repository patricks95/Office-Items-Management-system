using Microsoft.EntityFrameworkCore;
using UNISD.DbCont;
using UNISD.IRepo;
using UNISD.IServices;
using UNISD.Repo;
using UNISD.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<EmployeeContext>(Option => Option.UseSqlServer(
    builder.Configuration.GetConnectionString("uniString")));

builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IEmployeeService, EmployeeServicegh>();

builder.Services.AddScoped<IItemRepo, ItemRepo>();
builder.Services.AddScoped<IItemsService,ItemService>();



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
