using Core.Entities.Abstract;
namespace Entities.Concrete
{
    public class Customer:IEntity
    {
      public  int Id { get; set; }
      public  string Name { get; set; }
     public   string Surname { get; set; }
     public   int PriceId { get; set; }
      

    }
}
