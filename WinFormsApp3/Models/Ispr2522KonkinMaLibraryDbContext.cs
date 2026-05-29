using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace WinFormsApp3.Models;

public partial class Ispr2522KonkinMaLibraryDbContext : DbContext
{
    public Ispr2522KonkinMaLibraryDbContext()
    {
    }

    public Ispr2522KonkinMaLibraryDbContext(DbContextOptions<Ispr2522KonkinMaLibraryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<AvailableBooksView> AvailableBooksViews { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Reader> Readers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;username=ISPr25-22_KonkinMA;password=ISPr25-22_KonkinMA;database=ISPr25-22_KonkinMA_LibraryDB", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PRIMARY");

            entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<AvailableBooksView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AvailableBooksView");

            entity.Property(e => e.Authors).HasColumnType("text");
            entity.Property(e => e.AvailableQuantity).HasDefaultValueSql("'1'");
            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.GenreName).HasMaxLength(50);
            entity.Property(e => e.PublisherName).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PRIMARY");

            entity.HasIndex(e => e.GenreId, "GenreID");

            entity.HasIndex(e => e.Isbn, "ISBN").IsUnique();

            entity.HasIndex(e => e.PublisherId, "PublisherID");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.AvailableQuantity).HasDefaultValueSql("'1'");
            entity.Property(e => e.GenreId).HasColumnName("GenreID");
            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .HasColumnName("ISBN");
            entity.Property(e => e.PublisherId).HasColumnName("PublisherID");
            entity.Property(e => e.Quantity).HasDefaultValueSql("'1'");
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.Genre).WithMany(p => p.Books)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Books_ibfk_1");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books)
                .HasForeignKey(d => d.PublisherId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Books_ibfk_2");

            entity.HasMany(d => d.Authors).WithMany(p => p.Books)
                .UsingEntity<Dictionary<string, object>>(
                    "BookAuthor",
                    r => r.HasOne<Author>().WithMany()
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("BookAuthors_ibfk_2"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BookId")
                        .HasConstraintName("BookAuthors_ibfk_1"),
                    j =>
                    {
                        j.HasKey("BookId", "AuthorId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("BookAuthors");
                        j.HasIndex(new[] { "AuthorId" }, "AuthorID");
                        j.IndexerProperty<int>("BookId").HasColumnName("BookID");
                        j.IndexerProperty<int>("AuthorId").HasColumnName("AuthorID");
                    });
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PRIMARY");

            entity.HasIndex(e => e.GenreName, "GenreName").IsUnique();

            entity.Property(e => e.GenreId).HasColumnName("GenreID");
            entity.Property(e => e.GenreName).HasMaxLength(50);
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PRIMARY");

            entity.HasIndex(e => e.BookId, "BookID");

            entity.HasIndex(e => e.ReaderId, "ReaderID");

            entity.Property(e => e.LoanId).HasColumnName("LoanID");
            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.ReaderId).HasColumnName("ReaderID");

            entity.HasOne(d => d.Book).WithMany(p => p.Loans)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Loans_ibfk_1");

            entity.HasOne(d => d.Reader).WithMany(p => p.Loans)
                .HasForeignKey(d => d.ReaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Loans_ibfk_2");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId).HasName("PRIMARY");

            entity.HasIndex(e => e.PublisherName, "PublisherName").IsUnique();

            entity.Property(e => e.PublisherId).HasColumnName("PublisherID");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.PublisherName).HasMaxLength(100);
        });

        modelBuilder.Entity<Reader>(entity =>
        {
            entity.HasKey(e => e.ReaderId).HasName("PRIMARY");

            entity.Property(e => e.ReaderId).HasColumnName("ReaderID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.RegistrationDate).HasDefaultValueSql("curdate()");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUsers).HasName("PRIMARY");

            entity.Property(e => e.IdUsers)
                .ValueGeneratedNever()
                .HasColumnName("idUsers");
            entity.Property(e => e.Name).HasMaxLength(45);
            entity.Property(e => e.Password);
            entity.Property(e => e.UserRole)
                .HasMaxLength(45)
                .HasColumnName("UserRole");  // ← ИСПРАВЛЕНО! было "password"
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}