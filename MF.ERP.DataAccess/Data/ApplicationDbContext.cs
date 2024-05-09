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
        public virtual DbSet<Status> Status { set; get; }
        public virtual DbSet<TartgetType> TartgetTyps { set; get; }
        public virtual DbSet<Team> Teams { set; get; }
        public virtual DbSet<TeamArea> TeamAres { set; get; }
        public virtual DbSet<TeamTarget> TeamTarges { set; get; }
        public virtual DbSet<Title> Titles { set; get; }



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