using LabFiveServZast.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabFiveServZast
{
    public class AppDbContext: DbContext
    {
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Contestant> Contestants { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ActivityType> Activities { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Employer>()
                .HasOne(e => e.ActivityType)
                .WithMany(at => at.Employers);

            modelBuilder.Entity<Contestant>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Contestant>()
                .HasOne(c => c.ActivityType)
                .WithMany(at => at.Contestants);

            modelBuilder.Entity<Contract>()
                .HasKey(c => new { c.VacancyId, c.ContestantId });

            modelBuilder.Entity<Vacancy>()
                .HasKey(v => v.Id);
            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Employer)
                .WithMany(e => e.Vacancies);

            modelBuilder.Entity<ActivityType>()
                .HasKey(at => at.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
