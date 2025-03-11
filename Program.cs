using ArticleCRUD.Context;
using ArticleCRUD.Repository;
using Microsoft.EntityFrameworkCore;

namespace ArticleCRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Register DbContext
            var connectionString = builder.Configuration.GetConnectionString("TutorialDbConnection");
            builder.Services.AddDbContext<TutorialDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddScoped<ITutorialRepository, TutorialRepository>();
            //Register Article service
            builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
