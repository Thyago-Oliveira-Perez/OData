using Microsoft.AspNetCore.OData;
using OData.Services;

namespace OData
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddControllers().AddOData(
                options => 
                    options.Select()
                );
            services.AddTransient<IStudentService, StudentService>();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    
        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
