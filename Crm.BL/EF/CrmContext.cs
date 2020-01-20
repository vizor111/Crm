using System.Data.Entity;
using Crm.BL.Model;

namespace Crm.BL.EF
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("DBConnection")
        {
        }

        public DbSet<Check> Checks { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sell> Sells { get; set; }

        public DbSet<Seller> Sellers { get; set; }
    }
}
