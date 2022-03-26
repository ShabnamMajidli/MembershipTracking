using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMeetingService
    {
        void Add(Meeting meeting);
        void Update(Meeting meeting);
        void Delete(Meeting meeting);
        void DeleteAll();
        Meeting Get(int id);
        List<Meeting> GetAll();
        int GetNextId();
    }
}
