using Microsoft.EntityFrameworkCore;

namespace WebAPICrud.Model
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Designation> Designation { get; set; }
    }
}
