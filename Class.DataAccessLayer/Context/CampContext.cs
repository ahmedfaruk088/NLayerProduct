using Class.EntitLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.DataAccessLayer.Context
{
    public class CampContext:DbContext
    {
        public DbSet<Category> Categories { get; set; } // Category -> c# ta kullandığımız. categories -> sql e yansıyacak
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        internal object Set<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
