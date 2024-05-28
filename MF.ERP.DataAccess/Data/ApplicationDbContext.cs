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
       //public virtual DbSet<Actions> Actions { set; get; }
        public virtual DbSet<ActionStatus> ActionStatus { set; get; }
        public virtual DbSet<ActionDetailStatus> ActionDetailStatus { set; get; }
        public virtual DbSet<ActionType> ActionTypes { set; get; }
        public virtual DbSet<Area> Areas { set; get; }
        public virtual DbSet<Consume> Consumes { set; get; }
        public virtual DbSet<ContactPerson> ContactPersons { set; get; }
        public virtual DbSet<Customer> Customers { set; get; }
      public virtual DbSet<CustomerGroup> CustomerGroups { set; get; }
        public virtual DbSet<CustomerStatus> CustomerStatus { set; get; }
        public virtual DbSet<CustomerType> CustomerTyps { set; get; }
        public virtual DbSet<Government> Governmens { set; get; }
        public virtual DbSet<Industry> Industries { set; get; }
        public virtual DbSet<Job> Jobs { set; get; }
        public virtual DbSet<Order> Ordes { set; get; }
        public virtual DbSet<OrderDetail> OrderDetais { set; get; }
        public virtual DbSet<PaymentMethoud> PaymentMethous { set; get; }
        public virtual DbSet<PaymentPlan> PaymentPlas { set; get; }
        public virtual DbSet<PaymentPlanDetails> PaymentPlanDetails { set; get; }
        public virtual DbSet<PineLineAction> PineLineActions { set; get; }
        public virtual DbSet<PipeLine> PipeLins { set; get; }
        public virtual DbSet<PipeLineStatus> PipeLineStatus { set; get; }
        public virtual DbSet<Product> Products { set; get; }
        public virtual DbSet<Question> Questions { set; get; }
        public virtual DbSet<Representive> Representivs { set; get; }
        public virtual DbSet<RepresintiveTarget> RepresintiveTarges { set; get; }
        public virtual DbSet<OrderStatus> OrderStatus { set; get; }
        public virtual DbSet<TargetType> TargetTypes { set; get; }  
        public virtual DbSet<Title> Titles { set; get; }
        public virtual DbSet<ActionsMaster> ActionsMaster { set; get; }
        public virtual DbSet<ActionsDetails> ActionsDetails { set; get; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.ToTable("CustomerTypes");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.NameAr).IsUnicode().HasMaxLength(200).IsRequired();
                entity.Property(e => e.NameEn).IsUnicode().HasMaxLength(200).IsRequired();

            });

            modelBuilder.Entity<ActionsDetails>(entity =>
            {
                entity.ToTable("ActionsDetails");
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.ActionsMaster)
                 .WithMany(e => e!.Details)
                 .HasForeignKey(e => e.ActionsMasterId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Restrict);
                 
            modelBuilder.Entity<ActionsMaster>(entity =>
            {
                entity.ToTable("ActionsMaster");
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Representive)
.WithMany(e => e!.ActionsMaster)
.HasForeignKey(e => e.RepresentiveId)
.IsRequired()
.OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Customer)
.WithMany(e => e!.ActionsMasters)
.HasForeignKey(e => e.CustomerId)
.IsRequired()
.OnDelete(DeleteBehavior.Restrict);

            });

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