using System.Collections;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
    });
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // Добавление использования Swagger
    app.UseSwagger();

    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });

    // Другие настройки приложения
}