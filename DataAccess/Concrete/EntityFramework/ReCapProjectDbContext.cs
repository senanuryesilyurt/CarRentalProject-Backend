﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class ReCapProjectDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProjectDatabase;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}