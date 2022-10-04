using Microsoft.EntityFrameworkCore;
using UNISD.Entities;

namespace UNISD.DbCont
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
