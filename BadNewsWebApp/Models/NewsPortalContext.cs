using Microsoft.EntityFrameworkCore;
using System;

namespace BadNews.Models
{
    public class NewsPortalContext : DbContext
    {
        public NewsPortalContext(DbContextOptions<NewsPortalContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Post)
                .WithMany(c => c.Comments)
                .HasForeignKey(c => c.CommentId)
                .HasPrincipalKey(c => c.PostId);

            modelBuilder.Entity<Comment>()
                .HasOne(g => g.User)
                .WithMany(g => g.Comments)
                .HasForeignKey(g => g.CommentId)
                .HasPrincipalKey(g => g.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnDelete(DeleteBehavior restrict)
        {
            throw new NotImplementedException();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
