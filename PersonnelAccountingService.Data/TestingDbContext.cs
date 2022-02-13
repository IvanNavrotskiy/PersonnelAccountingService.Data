using Microsoft.EntityFrameworkCore;
using PersonnelAccountingService.Data.Entities;
using System;

namespace PersonnelAccountingService.Data
{
    public class TestingDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public TestingDbContext()
        {

        }
        public TestingDbContext(DbContextOptions<TestingDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=localdb;Username=root;Password=123");
        }
    }
}
