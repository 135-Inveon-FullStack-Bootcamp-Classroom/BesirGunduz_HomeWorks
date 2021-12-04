using FootballManager.API.Data;
using FootballManager.API.Services.Abstract;
using FootballManager.API.Services.Concrete;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace FootballManager.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //DI
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped<ICoachService, CoachService>();
            services.AddScoped<IFootballerService, FootballerService>();
            services.AddScoped<IManagementPositionService, ManagementPositionService>();
            services.AddScoped<IManagerService, ManagerService>();
            services.AddScoped<INationalTeamService, NationalTeamService>();
            services.AddScoped<ITacticService, TacticService>();
            services.AddScoped<ITeamService, TeamService>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FootballManager.API", Version = "v1" });
            });
            //DB Connection
            services.AddDbContext<EfContext>(x => x.UseSqlServer(Configuration.GetConnectionString("ConnStr")));

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FootballManager.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
