using Microsoft.EntityFrameworkCore;
using Refhub.Data.Models;
using System;

namespace Refhub.Data.Context;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options) { }

    // DbSets
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Keyword> Keywords { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<BookKeyword> BookKeywords { get; set; }
    public DbSet<BookRelation> BookRelations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppD‌BContext).Assembly);
    }
}

