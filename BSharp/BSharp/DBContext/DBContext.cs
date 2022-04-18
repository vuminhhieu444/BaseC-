using HNCHOME.Models;
using Microsoft.EntityFrameworkCore;

namespace BSharp.DBContext
{
    public class DBContext : DbContext
    {
        DbSet<Branch> Branches { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Department> Departmemnts { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<Menu> Menus { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Permission> Permissions { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Role> Roles { get; set; }
    }
}
