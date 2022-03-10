using Microsoft.EntityFrameworkCore;
using usingentity.Model;

namespace usingentity.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) :base(options) 
        { 

        }
        public DbSet<Student> Students { get; set; }
    }
}  
