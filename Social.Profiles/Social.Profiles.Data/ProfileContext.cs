using Microsoft.EntityFrameworkCore;
using Social.Profiles.Data.Models;
using System;

namespace Social.Profiles.Data
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options)
            : base(options) { }

        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
