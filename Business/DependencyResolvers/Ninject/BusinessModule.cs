
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Business.Concrete;
using Ninject.Modules;
using DattaAccess.Abstract;
using DattaAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();

            Bind<IMeetingDal>().To<EfMeetingDal>().InSingletonScope();
            Bind<IMeetingService>().To<MeetingManager>().InSingletonScope();

            Bind<IPriceDal>().To<EfPriceDal>().InSingletonScope();
            Bind<IPriceService>().To<PriceManager>().InSingletonScope();
        }
    }
}
