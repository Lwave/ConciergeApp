using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ConciergeApp.Models;

namespace ConciergeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Preference> Preferences { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Friend>().HasKey(f => new { f.FriendId, f.ApplicationUserId });
            builder.Entity<ApplicationUser>().HasMany(au => au.Friends).WithOne(f => f.AppUserFriend);
            builder.Entity<ApplicationUser>().HasMany(au => au.Feedbacks).WithOne(f => f.ApplicationUser);
            builder.Entity<ApplicationUser>().HasMany(au => au.Businesses).WithOne(b => b.ApplicationUser);
            builder.Entity<ApplicationUser>().HasMany(au => au.TheirFriends).WithOne(t => t.ApplicationUser);
            builder.Entity<Business>().HasMany(b => b.Feedbacks).WithOne(f => f.Business);
            builder.Entity<Feedback>().HasMany(f => f.Comments).WithOne(c => c.Feedback);

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
