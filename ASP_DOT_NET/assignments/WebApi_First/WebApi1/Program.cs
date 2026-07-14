using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using WebApi1.Data;

namespace WebApi1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register DbContext
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services
            builder.Services.AddControllers();

            // Register Swagger
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Employee API",
                    Version = "v1",
                    Description = "Employee Management Web API"
                });
            });

            var app = builder.Build();

            // Configure Swagger
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API v1");
                    options.RoutePrefix = "swagger";
                });
            }

            app.UseHttpsRedirection();

            // Redirect root URL to Swagger
            app.MapGet("/", () => Results.Redirect("/swagger"));

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}