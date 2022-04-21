using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.Common.Models;
using WebCar.WebApp._4_DataAcess.EntityConfiguration;

namespace WebCar.WebApp._4_DataAcess
{
    public class Context : DbContext
    {
        public DbSet<CarModel> CarDbSet { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfiguration());
        }
    }
}



