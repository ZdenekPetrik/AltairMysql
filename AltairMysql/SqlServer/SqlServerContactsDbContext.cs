using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DemoDbMulti.Data.SqlServer
{
    public class SqlServerContactsDbContext :ContactsDbContext
    {
        public SqlServerContactsDbContext(DbContextOptions options) : base(options) { }
    }

    public class SqlServerContactDbContextDesignTimeFactory : IDesignTimeDbContextFactory<SqlServerContactsDbContext>
    {
        public SqlServerContactsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlServerContactsDbContext>();
            optionsBuilder.UseSqlServer(@"Server=localhost; TRUSTED_CONNECTION=yes; Database=AltairDemo;");
            return new SqlServerContactsDbContext(optionsBuilder.Options);
        }
    }

}
