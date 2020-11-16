using SampleProject.Core.DataAccess;
using SampleProject.Entities.Concrete;

namespace SampleProject.DataAccess.Abstract
{
    public interface IDepartmentDal : IEntityRepository<Department>
    {
    }
}
