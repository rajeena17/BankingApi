using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApi.Data
{
    public class BankContext:DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }


        public DbSet<Bank> Banks { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)

        //{
        //    modelBuilder.Entity<Bank>().HasData(
        //        new Bank
        //        {

        //        })
        //    optionsBuilder.UseSqlServer();
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
