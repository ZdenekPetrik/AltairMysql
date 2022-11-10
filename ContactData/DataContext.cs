using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContactData
{
  public class DataContext : DbContext, IDataContext
  {
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
      Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      // connect to sql server database
      options.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
    }

    public DbSet<Contact> Contacts { get; set; }
  }
}
