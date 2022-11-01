using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DemoDbMulti.Data.Sqlite
{
    public class SqliteContactsDbContext : ContactsDbContext
    {
        public SqliteContactsDbContext(DbContextOptions options) : base(options) { }
    }

    public class SqlLiteContactDbContextDesignTimeFactory : IDesignTimeDbContextFactory<SqliteContactsDbContext>
    {
        public SqliteContactsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqliteContactsDbContext>();
            optionsBuilder.UseSqlServer(@"Server=localhost; TRUSTED_CONNECTION=yes; Database=AltairDemo;");
            return new SqliteContactsDbContext(optionsBuilder.Options);
        }
    }

}

