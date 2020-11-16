using SampleProject.Core.DataAccess.EntityFramework;
using SampleProject.DataAccess.Abstract;
using SampleProject.Entities.Concrete;

namespace SampleProject.DataAccess.Concrete.EntityFramework
{
    public class EfManagerDal : EfEntityRepositoryBase<Manager, SampleProjectContext>, IManagerDal
    {
    }
}
