﻿using CleanArchitecture.Domain.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace CleanArchitecture.Persistance.Context
{
    public sealed class CompanyDbContext : DbContext
    {
        private string ConnectionString = "";

        public CompanyDbContext(string companyId,Company company=null)
        {
            if (company !=null)
            {
                if (company.UserId == "" || company.UserId == null)
                    ConnectionString = $"Data Source={company.ServerName};Initial Catalog={company.DatabaseName};Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                else
                    ConnectionString = $"Data Source={company.ServerName};Initial Catalog={company.DatabaseName};UserId={company.UserId};Password={company.Password};Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            }
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

        public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {
       
            public CompanyDbContext CreateDbContext(string[] args)
            {
               
                return new CompanyDbContext("");
            }
        }
    }
}
