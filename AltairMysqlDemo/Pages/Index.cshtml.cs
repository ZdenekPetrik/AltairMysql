﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDbMulti.Data;
using Microsoft.EntityFrameworkCore;

namespace AltairMysqlDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ContactsDbContext _dc;

        public IndexModel(ILogger<IndexModel> logger, ContactsDbContext dc)
        {
            _logger = logger;
            _dc = dc;
        }


        public IEnumerable<Contact> Contacts { get; set; } = Enumerable.Empty<Contact>();


        public async Task OnGetAsync()
        {
            this.Contacts = await this._dc.Contacts.OrderBy(X => X.LastName).ToListAsync();
        }
    }
}
