using CrudSample.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudSample.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; } 
    }
}
