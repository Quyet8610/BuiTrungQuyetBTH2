using BuiTrungQuyetBTH2.Models;
using Microsoft.EntityFrameworkCore;

namespace BuiTrungQuyetBTH2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students {get; set;}
        public DbSet<Employee> Employees {get; set;}
    }
}