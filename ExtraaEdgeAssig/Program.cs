using ExtraaEdgeAssig.Data;
using ExtraaEdgeAssig.Repositories;
using ExtraaEdgeAssig.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container


builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value));


builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IBrandService, BrandService>();


builder.Services.AddScoped<IMobileRepository, MobileRepository>();
builder.Services.AddScoped<IMobileService, MobileService>();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();


builder.Services.AddScoped<IPurchaseRepository,PurchaseRepository>();
builder.Services.AddScoped<IPurchaseService, PurchaseService>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAuthorization();
app.MapControllers();
app.Run();