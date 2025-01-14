﻿using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts;

public class RentACarContext : DbContext
{
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Fuel> Fuels { get; set; }
    public DbSet<Transmission> Transmissions { get; set; }
    public DbSet<Model> Models { get; set; }

    public DbSet<Car> Cars { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
    public DbSet<CorporateCustomer> CorporateCustomers { get; set; }

    public RentACarContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Brand>().HasKey(i=> i.Id); // EF Core Naming Convention BrandId
        modelBuilder.Entity<Brand>(e =>
        {
            e.HasKey(i => i.Id);
            //e.Property(i => i.Premium).HasDefault(true);
        }) ;

        ////base.OnModelCreating(modelBuilder);// Normalde yaptığı işlemleri sürdürür.
    }
}
// Update-Database migrationIsmi
// Remove-Migration