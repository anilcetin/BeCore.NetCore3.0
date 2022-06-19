using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class MyBlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blog;Trusted_Connection=true");
        }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Social> Social { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<Experience> Experience { get; set; }
    }
}
