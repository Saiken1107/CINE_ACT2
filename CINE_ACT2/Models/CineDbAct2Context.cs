using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CINE_ACT2.Models;

public partial class CineDbAct2Context : DbContext
{
    private readonly IConfiguration _configuration;

    public CineDbAct2Context(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public CineDbAct2Context(DbContextOptions<CineDbAct2Context> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }
    
    //CF
    public virtual DbSet<Pelicula> Peliculas { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = _configuration.GetConnectionString("CineDbAct2Connection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pelicula>(entity =>
        {
            //BDF
            entity.HasKey(e => e.PeliculaId).HasName("PK__Pelicula__5AC6FCCC37D98DA1");
            entity.Property(e => e.Director).HasMaxLength(100);
            entity.Property(e => e.Titulo).HasMaxLength(100);

            //MF
            modelBuilder.Entity<Pelicula>().ToTable("Peliculas");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
