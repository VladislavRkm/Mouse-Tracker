using Microsoft.EntityFrameworkCore;
using MouseMouvementAPI.Models;
using System.Collections.Generic;

namespace MouseMouvementAPI.Database;

public class ApplicationDbContext : DbContext
{
    public DbSet<MouseMovement> MouseMovements { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
