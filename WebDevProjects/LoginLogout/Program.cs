using Microsoft.EntityFrameworkCore;
using LoginLogout.Models;
namespace LoginLogout
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<CodeFirstDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Login}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
