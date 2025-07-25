using Microsoft.EntityFrameworkCore;


namespace Employee.Model
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeData> EmployeeData { get; set; } 

        public DbSet<UserData> UserData { get; set; }
        /**/
    }

}
