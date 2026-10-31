using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository;
using EstoreAdminService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


//IOC is concept of Create Object forService in the
//Middleware before executing
builder.Services.Add(new ServiceDescriptor(
    typeof(IBrandService),
    typeof(BrandService),
    ServiceLifetime.Transient));


string _connectionString = builder.Configuration.GetConnectionString("EStoreAdminConnection");

//IOC of BrandRepository Class with the help of DBContext
builder.Services.AddDbContext<BrandRepository>(options =>
{
    options.UseSqlServer(_connectionString);
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();
app.MapControllers();

//Global Exception Middleware

app.Run();
