using Microsoft.EntityFrameworkCore;
using W15bCrudAjaxCodeFirst.Models;

namespace W15bCrudAjaxCodeFirst.AppDbContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }      // Table Name
    }
}
