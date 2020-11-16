using SampleProject.Entities.Concrete;
using System.Collections.Generic;

namespace SampleProject.Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        Department Get(int id);
        Department Add(Department department);
    }
}
