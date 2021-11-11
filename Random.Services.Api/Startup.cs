// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Random.Services.Api.Brokers.DateTimes;
using Random.Services.Api.Brokers.Loggings;

namespace Random.Services.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddLogging();
            AddBrokers(services);

            services.AddSwaggerGen(options =>
            {
                var openApiInfo = new OpenApiInfo
                {
                    Title = "Random.Services.Api",
                    Version = "v1"
                };

                options.SwaggerDoc(
                    name: "v1",
                    openApiInfo);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint(
                        url: "/swagger/v1/swagger.json",
                        name: "Random.Services.Api v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }

        private static void AddBrokers(IServiceCollection services)
        {
            services.AddTransient<IDateTimeBroker, DateTimeBroker>();
            services.AddTransient<ILoggingBroker, LoggingBroker>();
        }
    }
}
