using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DattaAccess.Abstract;
using Entities.Concrete;


namespace DattaAccess.Concrete.EntityFramework
{

    public class EfMeetingDal : EfEntityRepositoryBase<Meeting, MembershipContext>, IMeetingDal
    {
    }
}
