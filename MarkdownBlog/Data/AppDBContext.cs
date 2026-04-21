using Microsoft.EntityFrameworkCore;
using MarkdownBlog.Models;

namespace MarkdownBlog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Posts> Posts { get; set; }
    }
}