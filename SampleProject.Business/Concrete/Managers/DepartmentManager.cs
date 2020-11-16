using SampleProject.Business.Abstract;
using SampleProject.DataAccess.Abstract;
using SampleProject.Entities.Concrete;
using System.Collections.Generic;

namespace SampleProject.Business.Concrete.Managers
{
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public Department Add(Department department)
        {
            return _departmentDal.Add(department);
        }

        public Department Get(int id)
        {
            return _departmentDal.Get(x => x.Id == id);
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetList();
        }
    }
}
