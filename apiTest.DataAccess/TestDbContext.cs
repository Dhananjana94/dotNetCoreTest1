using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apitest.Models;
using Microsoft.EntityFrameworkCore;

namespace apiTest.DataAccess
{
    public class TestDbContext : DbContext
    {
        public DbSet<TstMdl> TstMdlTble { get; set; } //create database table

        //create db connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStr = "Server = laptop-8sgq0854; Database = TstApiDb; Integrated Security = true; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionStr);
        }

        //add dummy data to table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TstMdl>().HasData(new TstMdl
            {
                Id = 1,
                Title = "Test model 1",
                Description = "testing model 1",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TstStatus.New
            });
        }
    }
}
