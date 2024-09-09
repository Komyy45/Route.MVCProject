using Microsoft.EntityFrameworkCore;
using Route.MVCProject.DAL.Data;

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

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server = LAPTOP-5EBO3503\\SQLEXPRESS; Database = MVCApplication; Trusted_Connection = true; TrustServerCertificate = true"));

            #endregion

            var app = builder.Build();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); 

            #endregion

            app.Run();
        }
    }
}
