using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataLayer.Repositories
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<Author> Autors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Cover> Covers { get; set; }
        public DbSet<Tag> TAgs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
