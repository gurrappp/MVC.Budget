using MVC.Budget.Context;
using Microsoft.EntityFrameworkCore;

namespace MVC.Budget
{
    public static class Setup
    {
        public static WebApplication? CreateWebApplication()
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddDbContext<BudgetContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BudgetContext") ?? throw new InvalidOperationException("Connection string 'BudgetContext' not found.")));

            builder.Services.AddControllersWithViews();

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

            return app;
        }
    }
}
