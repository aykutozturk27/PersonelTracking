using SampleProject.Core.DataAccess.EntityFramework;
using SampleProject.DataAccess.Abstract;
using SampleProject.Entities.Concrete;

namespace SampleProject.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, SampleProjectContext>, IEmployeeDal
    {
    }
}
