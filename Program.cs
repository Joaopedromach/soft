using Microsoft.EntityFrameworkCore;
using Soft.Models;

namespace Soft
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            builder.Services.AddControllersWithViews();
            builder.Services.AddEntityFrameworkNpgsql()
                .AddDbContext<Contexto>(options =>
                options.UseNpgsql("host=localhost;Port=5432;Pooling=true;Database=Softline;User Id=postgres;Password=root"));

            var app = builder.Build();

          
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=LoginPagina}/{action=Index}/{id?}");

            app.Run();
        }
    }
}