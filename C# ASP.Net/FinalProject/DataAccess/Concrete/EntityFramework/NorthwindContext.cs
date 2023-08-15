using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    // DbContext : EntityFramework'te kullanılan sınıf
    public class NorthwindContext:DbContext
    {
        // Bu metod projenin hangi veritabanı ile ilişkili olduğunu belirteceğimiz yerdir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql server kullanacağımızı belirtiyoruz
            //konumunu belirtiyoruz
            //Trusted_Connection=true : Kullanıcı adı ve şifre istemeden giriş yapar
            //databaseimizin ismini belirtiyoruz

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        // Hangi nesnem hangi nesneye karşılık gelecek onu belirtiyoruz
        // DbSet : Hangi nesneye karşılık geliyorsa onu yazıyoruz
        // Product : Hangi nesneye karşılık geliyorsa onu yazıyoruz
        // Products : Tablomuzun ismi
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
