using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;

namespace WebApplication1
{
    // ! Add the following NuGet Package:
    //      (a) Microsoft.EntityFrameworkCore (project .NET Version)
    //      (b) Microsoft.EntityFrameworkCore.SqlServer (project .NET Version)
    //      (c) Microsoft.EntityFrameworkCore.Tools (project .NET Version)  -- for EF Core Data Migrations
    //      NOTE: Make sure all the three Nuget packages for EF Core have the same version!!!!
    //      (d) Swashbuckle.AspNetCore    for OpenAPI Documentation generation
    //          Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    //  Add the connection string in appsetting.json file.
    //  NOTE: Sometimes you will get the following error:
    //             The certificate received from the remote server was issued by
    //             an untrusted certificate authority error when you connect to SQL Server.
    //             To correct this, add "TrustServerCertificate=True" to connection string.

    public class Program
    {
        private const string connectionNAME = "MyDefaultConnectionString";
        private const string INVALIDconnection = $"Connection string '{connectionNAME}' not found.";

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add EF Core services to the container.
            var connectionString 
                = builder.Configuration.GetConnectionString(connectionNAME) 
                  ?? throw new InvalidOperationException(INVALIDconnection);
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // Add services to the container.
            builder.Services.AddRazorPages();           // Register ASP.NET Razor Pages related services
            builder.Services.AddControllers();          // !Register ASP.NET Controller related services
            builder.Services.AddEndpointsApiExplorer(); // !Register the OpenAPI Endpoints
            builder.Services.AddSwaggerGen();           // !Register the OpenAPI Compliant Swagger Documentatation

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // !Configure the HTTP request pipeline for OpenAPI/Swagger documentation.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();                // Register ASP.NET Routing to all the Razor Pages.
            app.MapControllers();               // !Register ASP.NET Routing to register all the Controllers!

            app.Run();
        }
    }
}