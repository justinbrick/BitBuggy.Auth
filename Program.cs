using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Host
    .CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        // Web specific services.
        webBuilder.ConfigureServices(services =>
        {
            services
                .AddEndpointsApiExplorer()
                .AddSwaggerGen()
                .AddControllers();
        });

        webBuilder.Configure(app =>
        {
            app
                .UseRouting()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
        });
    })
    .ConfigureServices((ctx, services) =>
    {

    })
    .Build()
    .Run();





