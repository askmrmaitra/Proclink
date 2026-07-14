using Dapper_Apis.Data;
using Dapper_Apis.Repository;
using Microsoft.OpenApi;


namespace Dapper_Apis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Register Dapper Context
            builder.Services.AddSingleton<DapperContext>();

            // Register Repository
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            // Swagger
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Dapper APIs",
                    Version = "v1",
                    Description = "ASP.NET Core Web API using Dapper"
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Dapper APIs V1");
                    options.RoutePrefix = string.Empty;
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}