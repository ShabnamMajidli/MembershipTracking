using Core.Entities.Abstract;
namespace Entities.Concrete
{
    public class Meeting:IEntity
    {
      public  int Id { get; set; }
     public   string Name { get; set; }
    public    int UserCount { get; set; }
    }
}
