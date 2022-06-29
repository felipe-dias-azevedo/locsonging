using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Infrastructure;
using Felipe.Backend.Locsonging.Infrastructure.Repository;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;
using Felipe.Backend.Locsonging.Service.Domain;
using Felipe.Backend.Locsonging.Service.Domain.Interface;

namespace Felipe.Backend.Locsonging
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.Configure<MongoSettings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoDatabaseSettings:ConnectionString").Value;
                options.Database = Configuration.GetSection("MongoDatabaseSettings:DatabaseName").Value;
            });
            
            services.AddScoped<IMongoContext, MongoDbContext>();

            services.AddTransient<ISongService, SongService>();
            services.AddTransient<ISongRepository, SongRepository>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // TODO: Add Exception Handler for custom exceptions

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
