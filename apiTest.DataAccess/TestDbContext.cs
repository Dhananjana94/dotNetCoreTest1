using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apitest.Models;
using apiTest.Models;
using Microsoft.EntityFrameworkCore;

namespace apiTest.DataAccess
{
    public class TestDbContext : DbContext
    {
        public DbSet<TstMdl> TstMdlTble { get; set; } //create database table
        public DbSet<Author> Authors { get; set; }

        //create db connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStr = "Server = laptop-8sgq0854; Database = TstApiDb; Integrated Security = true; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionStr);
        }

        //add dummy data to table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TstMdl>().HasData(new TstMdl[]
            {
                new TstMdl
                {
                    Id = 1,
                    Title = "Test model 1 from sql",
                    Description = "testing model 1",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now.AddDays(5),
                    Status = TstStatus.New,
                    AuthorId = 1
                },
                 new TstMdl
                {
                    Id = 2,
                    Title = "Test model 2",
                    Description = "testing model 2",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now.AddDays(5),
                    Status = TstStatus.New,
                    AuthorId = 1
                },
                  new TstMdl
                {
                    Id = 3,
                    Title = "Test model 3",
                    Description = "testing model 3",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now.AddDays(5),
                    Status = TstStatus.New,
                    AuthorId = 2
                }

            });

            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id = 1,Name = "Wasantha perera"},
                new Author { Id = 2,Name="Wasthi anushka"},
                new Author { Id = 3,Name="Sumanapala herath"}
            });
        }
    }
}
