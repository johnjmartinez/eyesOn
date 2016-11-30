using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL;

using EyesOn.Data.Model.Server;

namespace EyesOn.Data
{
    public partial class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(@"Server=66.205.191.184;port=5433;Database=EyesOn;User Id=Shades;Password=thahuC!3YuwR;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<User>(entity =>
            {
                //entity.HasKey(k => new { k.Category, k.Subcategory, k.Manufacturer, k.Type, k.Description, k.TCC });
                entity.HasKey(k => k.Id);
                entity.Property(e => e.Id).IsRequired().HasColumnName("id");
                entity.Property(e => e.Email).IsRequired().HasColumnName("email");
                entity.Property(e => e.Password).IsRequired().HasColumnName("password");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.ToTable("users", schema: "cloud");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasKey(k => k.Id);
                entity.Property(e => e.Id).IsRequired().HasColumnName("id");
                entity.Property(e => e.UserId).IsRequired().HasColumnName("user_id");
                entity.HasOne<User>(k => k.SubmittedBy).WithMany(x => x.Photos).HasForeignKey(k => k.UserId).HasConstraintName("photos_user");
                entity.ToTable("photos", schema: "cloud");
            });
            
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
    }
}
