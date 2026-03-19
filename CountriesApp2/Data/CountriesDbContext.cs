using System;
using System.Collections.Generic;
using CountriesApp2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CountriesApp2.Data;

public partial class CountriesDbContext : DbContext
{
    public CountriesDbContext()
    {
    }

    public CountriesDbContext(DbContextOptions<CountriesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Town> Towns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=CountriesDb;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Countrie__10D1609F0651BCE0");

            entity.Property(e => e.CountryName).HasMaxLength(100);
        });

        modelBuilder.Entity<Town>(entity =>
        {
            entity.HasKey(e => e.TownId).HasName("PK__Towns__01AA6251BCE1C58C");

            entity.Property(e => e.TownName).HasMaxLength(100);

            entity.HasOne(d => d.Country).WithMany(p => p.Towns)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__Towns__CountryId__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
