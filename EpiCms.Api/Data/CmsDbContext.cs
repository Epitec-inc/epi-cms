using Microsoft.EntityFrameworkCore;
using System;

namespace EpiCms.Api.Data
{
    public class CmsDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public CmsDbContext(DbContextOptions<CmsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData
           (
                 new Contact
                 {
                     Id = Guid.Parse("6F54170C-1E23-4D3A-A578-8F0D1F8E87F5"),
                     LastName = "Penduko",
                     FirstName = "Pedro",
                     BirthDate = DateTime.Parse("11/4/1969"),
                     PhoneNumber = "248-111-2222",
                     IsActive = true,
                     InActivatedDate = null,
                     CreatedDate = DateTime.UtcNow
                 },
                 new Contact
                 {
                     Id = Guid.Parse("2E0663BD-ADC1-4381-982D-785444979A2F"),
                     LastName = "Talisman",
                     FirstName = "Julian",
                     BirthDate = DateTime.Parse("02/14/1971"),
                     PhoneNumber = "248-333-4444",
                     IsActive = true,
                     InActivatedDate = null,
                     CreatedDate = DateTime.UtcNow
                 }
            );

            modelBuilder.Entity<Customer>().HasData
           (
                 new Customer
                 {
                     Id = Guid.Parse("6F54170C-1E23-4D3A-A578-8F0D1F8E87F5"),
                     Name = "Cool Business inc.",
                     PhoneNumber = "248-111-2222",
                     StreetAddress = "1234 cool street",
                     City = "Southfield",
                     State = "MI",
                     PostalCode = "12345",
                     Country = "US",
                     CreatedDate = DateTime.UtcNow,
                     IsActive = true
                 }
            );
        }
    }
}
