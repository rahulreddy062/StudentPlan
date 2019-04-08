﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentPlan.Models;
using StudentPlan.Models.Models;

namespace StudentPlan.Data

{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Credit> Credits {get; set;}
        public DbSet<Student> Students { get; set; }
        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<DegreeRequirement> DegreeRequirements {get; set;}
        public DbSet<StudentTerm> StudentTerms { get; set; }
        public DbSet<Developer> Developers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<Credit>().ToTable("Credit");
            modelBuilder.Entity<DegreeRequirement>().ToTable("DegreeRequirements");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlan");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Slot>().ToTable("Slot");
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerm");
        }
    }
}