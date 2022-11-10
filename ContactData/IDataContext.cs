using Microsoft.EntityFrameworkCore;

namespace ContactData
{
  public interface IDataContext
  {
    DbSet<Contact> Contacts { get; set; }
  }
}