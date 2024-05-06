using DrinkShopV3ConsoleAppCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using DrinkShopV3ConsoleAppCodeFirst.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkShopV3ConsoleAppCodeFirst.Data
{
    public class DrinkShopConAppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Drink> Drinks { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=DrinkShopConAppDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            // hard coding a connection string like above is bad practice – only doing
            // this way for demo purposes – should always use a secure
            // storage method for real-world connection strings. 
            // For secure connection string guidance: https://aka.ms/ef-core-connection-strings 
        }
    }
}
