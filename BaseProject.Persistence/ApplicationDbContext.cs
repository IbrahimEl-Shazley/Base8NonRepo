﻿using BaseProject.Domain.Entities.AdditionalTables;
using BaseProject.Domain.Entities.Chat;
using BaseProject.Domain.Entities.Cities_Tables;
using BaseProject.Domain.Entities.Copon;
using BaseProject.Domain.Entities.SettingTables;
using BaseProject.Domain.Entities.UserTables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationDbUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Copon> Copon { get; set; }
        public DbSet<CoponUsed> CoponUsed { get; set; }
        public DbSet<HubConnection> HubConnections { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderInfo> OrderInfos { get; set; }
        public DbSet<HistoryNotify> HistoryNotify { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationDbUser>().HasQueryFilter(c => !c.IsDeleted);
            builder.Entity<ContactUs>().HasQueryFilter(c => !c.IsDeleted);
            builder.Entity<Copon>().HasQueryFilter(c => !c.IsDeleted);

            //builder.Seed();

            builder.Entity<ApplicationDbUser>()
            .HasMany(c => c.Sender)
            .WithOne(o => o.Sender)
            .HasForeignKey(o => o.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationDbUser>()
                       .HasMany(c => c.Receiver)
                       .WithOne(o => o.Receiver)
                       .HasForeignKey(o => o.ReceiverId)
                       .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationDbUser>()
                    .HasMany(c => c.Orders)
                    .WithOne(o => o.User)
                    .HasForeignKey(o => o.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
      
        }

    }

}
