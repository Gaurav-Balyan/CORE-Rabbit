using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-8F9UVB93;Database=BankingDB;Trusted_Connection=True;MultipleActiveResultSets=True;");

            return new BankingDbContext(optionsBuilder.Options);
        }
    }

    public class BankingDbContext: DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }    }
}
