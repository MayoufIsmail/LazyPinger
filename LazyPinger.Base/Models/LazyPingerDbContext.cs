using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LazyPinger.Base.Models;

public partial class LazyPingerDbContext : DbContext
{
    public LazyPingerDbContext()
    {
    }

    public LazyPingerDbContext(DbContextOptions<LazyPingerDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=./lazypinger_database.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
