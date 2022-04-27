using Microsoft.EntityFrameworkCore;

namespace BlazorClassServer.Models;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; } = null!;
    public virtual DbSet<Contact> Contacts { get; set; } = null!;
    public virtual DbSet<Student> Students { get; set; } = null!;
    public virtual DbSet<StudentContact> StudentContacts { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.Property(e => e.AddressId).ValueGeneratedNever();

            entity.Property(e => e.City).HasMaxLength(100);

            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Street).HasMaxLength(200);

            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("Contact");

            entity.Property(e => e.ContactId).ValueGeneratedNever();

            entity.Property(e => e.Email).HasMaxLength(100);

            entity.Property(e => e.FirstName).HasMaxLength(50);

            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.Property(e => e.Mobile)
                .HasMaxLength(14)
                .IsUnicode(false);

            entity.HasOne(d => d.Address)
                .WithMany(p => p.Contacts)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_Contact_AddressId");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.StudentId)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.FirstName).HasMaxLength(50);

            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.Property(e => e.SchoolCode)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.HasOne(d => d.Address)
                .WithMany(p => p.Students)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_Student_AddressId");
        });

        modelBuilder.Entity<StudentContact>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.ContactId });

            entity.ToTable("StudentContact");

            entity.Property(e => e.StudentId)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Relationship).HasMaxLength(50);

            entity.HasOne(d => d.Contact)
                .WithMany(p => p.StudentContacts)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentContact_ContactId");

            entity.HasOne(d => d.Student)
                .WithMany(p => p.StudentContacts)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentContact_StudentId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}