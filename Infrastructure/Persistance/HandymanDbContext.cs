using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Infrastructure.Persistance
{
    public class HandymanDbContext : DbContext, IHandymanDbContext
    {
        /// <summary>
        /// Initialization constructor for HandymanDbContext class
        /// </summary>
        /// <param name="options"></param>
        public HandymanDbContext(DbContextOptions<HandymanDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<WorkType> WorkTypes { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<HandymanAbility> HandymanAbilities { get; set; }

        public DbSet<Intervention> Interventions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
} 
