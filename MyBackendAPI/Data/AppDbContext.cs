﻿using Microsoft.EntityFrameworkCore;
using MyBackendAPI.Models;

namespace MyBackendAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
    }
}
