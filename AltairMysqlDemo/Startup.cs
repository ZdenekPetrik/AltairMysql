using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDbMulti.Data;
using Microsoft.EntityFrameworkCore;
using DemoDbMulti.Data.SqlServer;
using DemoDbMulti.Data.Sqlite;

namespace AltairMysqlDemo
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    public IConfiguration _configuration { get; }


    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddRazorPages();
      if (_configuration["UseDbEngine"].Equals("SqlServer", StringComparison.OrdinalIgnoreCase))
      {
        services.AddDbContext<SqlServerContactsDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("SqlServer")));
      }
      if (_configuration["UseDbEngine"].Equals("Sqlite", StringComparison.OrdinalIgnoreCase))
      {
        services.AddDbContext<SqliteContactsDbContext>(options => options.UseSqlite(_configuration.GetConnectionString("Sqlite")));
      }
    }
      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      using (var scope = app.ApplicationServices.CreateScope())
      {
        var services = scope.ServiceProvider;
        if (_configuration["UseDbEngine"].Equals("SqlServer", StringComparison.OrdinalIgnoreCase))
        {
         // var context = services.GetRequiredService<SqlServerContactsDbContext>();
         // context.Database.Migrate();
        }
        if (_configuration["UseDbEngine"].Equals("Sqlite", StringComparison.OrdinalIgnoreCase))
        {
         // var context = services.GetRequiredService<SqliteContactsDbContext>();
         // context.Database.Migrate();
        }
        //  DbInitializer.Initialize(context);
      }
      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthorization();


      app.UseEndpoints(endpoints =>
      {
        endpoints.MapRazorPages();
      });
    }
  }
}
