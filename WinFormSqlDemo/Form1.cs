using ContactData;
using DemoDbMulti.Data;
using DemoDbMulti.Data.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSqlDemo
{
  public partial class Form1 : Form
  {
    private readonly ILogger<Form1> _logger;
    protected readonly IConfiguration _configuration;
    private readonly IDataContext _dc1;

    public IEnumerable<ContactData.Contact> Contacts { get; set; } = Enumerable.Empty<ContactData.Contact>();
    public IEnumerable<ContactData.Contact> Contacts1 { get; set; } = Enumerable.Empty<ContactData.Contact>();

    public Form1(ILogger<Form1> logger, IConfiguration configuration,IDataContext dc1)
    {
      _logger = logger;
      _configuration = configuration;
      _dc1 = dc1;
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //DataContext dc = new DataContext(_configuration);
      //this.Contacts = dc.Contacts.OrderBy(X => X.LastName).ToList();
      this.Contacts1 = _dc1.Contacts.OrderBy(X => X.LastName).ToList();
    }
  }
}








