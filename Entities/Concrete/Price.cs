
using Core.Entities.Abstract;

namespace Entities.Concrete
{
   public class Price:IEntity
    {
       public int Id { get; set; }
       public string Type { get; set; }
      public  int Value { get; set; }
    }
}
