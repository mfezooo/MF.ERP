using MF.ERP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.ERP.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //public virtual DbSet<Customer> Customers { set; get; }
        //public virtual DbSet<ContactPerson> ContactPersons { set; get; }
        public virtual DbSet<CustomerType> CustomerTypes { set; get; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.ToTable("CustomerTypes");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.NameAr).IsUnicode().HasMaxLength(200).IsRequired();
                entity.Property(e => e.NameEn).IsUnicode(false).HasMaxLength(200).IsRequired(); 

            });
            //modelBuilder.Entity<Customer>(entity =>
            //{
            //    entity.ToTable("Customers");
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.NameAr).IsUnicode().HasMaxLength(200).IsRequired();
            //    entity.Property(e => e.NameEn).IsUnicode(false).HasMaxLength(200).IsRequired();
            //    entity.Property(e => e.Email).IsUnicode(false).HasMaxLength(50).HasDefaultValue(null);
            //    entity.Property(e => e.Periority).IsUnicode(false).HasMaxLength(2).HasDefaultValue(0);

            //});
            //modelBuilder.Entity<ContactPerson>(entity =>
            //{
            //    entity.ToTable("ContactPersons");
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.NameAr).IsUnicode().HasMaxLength(200).IsRequired();
            //    entity.Property(e => e.NameEn).IsUnicode(false).HasMaxLength(200).IsRequired();
            //    entity.Property(e => e.Email).IsUnicode(false).HasMaxLength(50).HasDefaultValue(null);
            //    entity.Property(e => e.Phone ).IsUnicode(false).HasMaxLength(50).HasDefaultValue(null);
            //    entity.Property(e => e.UserCreated ).IsRequired();
            //});

        }

    }
}