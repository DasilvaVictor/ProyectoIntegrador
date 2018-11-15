using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiHotel.Models
{
    public partial class WebApiHotelDBContext : IdentityDbContext
    {
       
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<EstadoHabitaciones> EstadoHabitaciones { get; set; }
        public virtual DbSet<Habitaciones> Habitaciones { get; set; }
        public virtual DbSet<TipoHabitaciones> TipoHabitaciones { get; set; }

        public WebApiHotelDBContext(DbContextOptions<WebApiHotelDBContext> options) : base(options)
        {

        }
     /*   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=WebApiHotelDB;Integrated Security=False;User ID=sa;Password=sql;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           /* modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasIndex(e => e.Dni)
                    .IsUnique();

                entity.Property(e => e.Dni).HasColumnName("DNI");
            });

            modelBuilder.Entity<EstadoHabitaciones>(entity =>
            {
                entity.HasIndex(e => e.HabitacionId)
                    .IsUnique();

                entity.Property(e => e.HabitacionId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Habitacion)
                    .WithOne(p => p.EstadoHabitaciones)
                    .HasForeignKey<EstadoHabitaciones>(d => d.HabitacionId);
            });

            modelBuilder.Entity<Habitaciones>(entity =>
            {
                entity.HasKey(e => e.Codigo);
            });

            modelBuilder.Entity<TipoHabitaciones>(entity =>
            {
                entity.HasIndex(e => e.HabitacionId)
                    .IsUnique();

                entity.Property(e => e.HabitacionId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Habitacion)
                    .WithOne(p => p.TipoHabitaciones)
                    .HasForeignKey<TipoHabitaciones>(d => d.HabitacionId);
            });*/
        }
    }
}
