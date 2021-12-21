using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HexFinderDb;Trusted_Connection=true");
        }

        public DbSet<Datas> Datas { get; set; }
        public DbSet<Servers> Servers { get; set; }
    }
}
