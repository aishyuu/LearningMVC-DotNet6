using LearningMVC_DotNet6.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningMVC_DotNet6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
    }
}
