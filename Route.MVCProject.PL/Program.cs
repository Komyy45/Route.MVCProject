using Microsoft.EntityFrameworkCore;
using Route.MVCProject.BLL.Interfaces;
using Route.MVCProject.BLL.Repositories;
using Route.MVCProject.DAL.Data;
using Route.MVCProject.DAL.Models;

namespace Route.MVCProject.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Configure Services

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IDepartmentRepository,DepartmentRepository>();

            #endregion

            var app = builder.Build();

            // Apply Migrations
            // Data Seeding

            // Configure the HTTP request pipeline.
            #region Configure
            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); 

            #endregion

            app.Run();
        }
    }
}
