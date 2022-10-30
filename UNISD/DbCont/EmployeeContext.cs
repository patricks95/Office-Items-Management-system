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
        public DbSet<Item> Items { get; set; }
        public DbSet<IssueItem> IssueItems { get; set; }
        public DbSet<Upgrade> Upgrades { get; set; }
        public DbSet<FaultReport> FaultReports { get; set; }
        public DbSet<ShopDetail> ShopDetails { get; set; }

    }
}
