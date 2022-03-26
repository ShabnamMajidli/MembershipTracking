

using Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DattaAccess.Concrete.EntityFramework.Mappings
{
    public class PriceMap: EntityTypeConfiguration<Price>
    {
        public PriceMap()
        {
            ToTable("Prices");
            HasKey(m => m.Id);
            Property(m => m.Type).HasColumnName("Type");
            Property(m => m.Value).HasColumnName("Value");
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


        }
    }
}
