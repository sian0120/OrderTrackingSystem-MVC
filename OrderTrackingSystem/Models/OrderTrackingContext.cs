using Microsoft.EntityFrameworkCore;

namespace OrderTrackingSystem.Models
{
    public class OrderTrackingContext : DbContext
    {
        public OrderTrackingContext(DbContextOptions<OrderTrackingContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
