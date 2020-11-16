using Ninject.Modules;
using SampleProject.Business.Abstract;
using SampleProject.Business.Concrete.Managers;
using SampleProject.Core.DataAccess;
using SampleProject.Core.DataAccess.EntityFramework;
using SampleProject.DataAccess.Abstract;
using SampleProject.DataAccess.Concrete.EntityFramework;
using System.Data.Entity;

namespace SampleProject.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();

            Bind<IDepartmentService>().To<DepartmentManager>().InSingletonScope();
            Bind<IDepartmentDal>().To<EfDepartmentDal>().InSingletonScope();

            Bind<IManagerService>().To<ManagerManager>().InSingletonScope();
            Bind<IManagerDal>().To<EfManagerDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>)).InSingletonScope();

            Bind<DbContext>().To<SampleProjectContext>().InSingletonScope();
        }
    }
}
