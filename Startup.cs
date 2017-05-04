using ConsoleApplication.Models;
using ConsoleApplication.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection servises)
        {
            // 3. register you db context so it can be used, and run again --- thats it! 
            servises.AddDbContext<MyDbContext>();
            // 4. Now delete your database, and your migrations
            // do a:
            //       dotnet ef migrations add first
            //       dotnet ef database update
            //       dotnet run
            servises.AddMvc();
            servises.AddScoped<IStudentRepository, StudentRepository>();
            servises.AddScoped<ICourseRepository, CourseRepository>();
           // servises.AddScoped<IStudentRepository, SimpleStudentRepository>();
        }

       public void Configure(IApplicationBuilder app, ILoggerFactory logger, MyDbContext context) // 1. add a context parameter
       {
           app.UseStaticFiles();
            // Log to the Console
            logger.AddConsole();
            app.UseMvcWithDefaultRoute();
            DbInitializer.Initialize(context);  // 2. add this and run the program
                                                // You will get a runtime error:
                                                // No service for type 'ConsoleApplication.Models.MyDbContext' has been registered.
                                                // 
       }
    }
}