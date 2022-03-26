using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPriceService
    {
        void Add(Price price);
        void Update(Price price);
        void Delete(Price price);
        void DeleteAll();
         Price Get(int id);
        List<Price> GetAll();
        int GetNextId();
    }
}
