using ContactData;
using DemoDbMulti.Data;
using DemoDbMulti.Data.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSqlDemo
{
  static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var host = CreateHostBuilder().Build();
      ServiceProvider = host.Services;

      Application.Run(ServiceProvider.GetRequiredService<Form1>());
    }

    public static IServiceProvider ServiceProvider { get; private set; }
    static IHostBuilder CreateHostBuilder()
    {
      return Host.CreateDefaultBuilder()
          .ConfigureServices((context, services) =>
          {
            services.AddTransient<IDataContext, DataContext>();
            services.AddTransient<Form1>();
          });
    }

  }
}
