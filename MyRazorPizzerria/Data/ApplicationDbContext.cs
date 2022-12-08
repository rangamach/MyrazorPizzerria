using Microsoft.EntityFrameworkCore;
using MyRazorPizzerria.Models;

namespace MyRazorPizzerria.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<PizzaOrderModel> PizzaOrders { get; set; }
    }
}
