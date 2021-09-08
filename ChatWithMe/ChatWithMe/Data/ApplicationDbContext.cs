namespace ChatWithMe.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    using ChatWithMe.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Friend> Friends { get; set; }

        public DbSet<FriendRequest> FriendRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasMany(u => u.FriendRequests)
                .WithOne(fr => fr.ToUser);

            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Friends)
                .WithOne(f => f.ApplicationUser);
        }
    }
}
