using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace DemoDbMulti.Data
{
    public abstract class ContactsDbContext :DbContext
    {
        public ContactsDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Contact> Contacts => this.Set<Contact>();

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, FirstName = "Jan", LastName = "Novák", EmailAddress = "jannovak@xxx.cz" , PhoneNumber = "+420 111 111 111" },
                new Contact { Id = 2, FirstName = "František", LastName = "Slezák" },
                new Contact { Id = 3, FirstName = "Josefína", LastName = "Vořežprutová", EmailAddress = "vores@seznam.cz" },
                new Contact { Id = 4, FirstName = "Robert", LastName = "Walker", EmailAddress = "www@pet.cz" },
                new Contact { Id = 5, FirstName = "Kamila", LastName = "Dvořáková", EmailAddress = "kamce@email.cz", PhoneNumber = "+420 123 456 789" },
                new Contact { Id = 6, FirstName = "Nikola", LastName = "Janků", EmailAddress = "nikolka@xxx.cz" }
                );
            */
        }
    }
  }
