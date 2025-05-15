using Microsoft.EntityFrameworkCore;
using System;

namespace Refhub.Data.Context;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options) { }
}
