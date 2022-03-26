

using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customers");
            HasKey(m => m.Id);
            Property(m => m.Name).HasColumnName("Name");
            Property(m => m.Surname).HasColumnName("Surname");
            Property(m => m.PriceId).HasColumnName("PriceId");
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


        }
    }
}
