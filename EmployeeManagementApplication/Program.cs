using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManagementApplication.Data;
using EmployeeManagementApplication.Repository.Interfaces;
using EmployeeManagementApplication.Repository.Implementations;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using EmployeeManagementApplication.Models;

namespace EmployeeManagementApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<EmployeeManagementApplicationContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeManagementApplicationContext") ?? throw new InvalidOperationException("Connection string 'EmployeeManagementApplicationContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IUnitofWork, UnitofWork>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IEmployeeSkillRepository, EmployeeSkillRepository>();
            builder.Services.AddScoped<ISkillRepository, SkillRepository>();
            builder.Services.AddScoped<IGenericRepository<Employee>,GenericRepository<Employee>>();  
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}