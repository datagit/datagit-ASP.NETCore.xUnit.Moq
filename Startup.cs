using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UnitTest_Mock.Model;
using UnitTest_Mock.Services;

namespace XUnitSample
{
  public class Startup
  {
      private const string connectionString = @"
                Data Source=localhost,1433;
                Initial Catalog=mydb_test1;
                User ID=SA;Password=Password123";
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      #region Connection String
      services.AddDbContext<AppDbContext>(item => item.UseSqlServer(connectionString));
      #endregion
      services.AddScoped<IEmployeeService, EmployeeService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapGet("/", async context =>
              {
                await context.Response.WriteAsync("Hello World!");
              });
      });
    }
  }
}
