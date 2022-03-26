using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DattaAccess.Concrete.EntityFramework.Mappings
{
    public class MeetingMap: EntityTypeConfiguration<Meeting>
    {
        public MeetingMap()
        {
            ToTable("Meetings");
            HasKey(m => m.Id);
            Property(m => m.Name).HasColumnName("Name");
            Property(m => m.UserCount).HasColumnName("UserCount");
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


        }
    }
}
