using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class MembershipContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Price> Prices { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
           // modelBuilder.Configurations.Add(new MeetingMap());
        }
    }
}
