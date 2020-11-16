using SampleProject.Business.Abstract;
using SampleProject.Core.DataAccess;
using SampleProject.DataAccess.Abstract;
using SampleProject.Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SampleProject.Business.Concrete.Managers
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        private IQueryableRepository<Employee> _queryableRepository;
        public EmployeeManager(IEmployeeDal employeeDal, IQueryableRepository<Employee> queryableRepository)
        {
            _employeeDal = employeeDal;
            _queryableRepository = queryableRepository;
        }

        public Employee Add(Employee employee)
        {
            return _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public Employee Get(int id)
        {
            return _employeeDal.Get(x => x.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            var list = _queryableRepository.Table.Include(x => x.Department).Include(x => x.Manager).ToList();
            return list;
        }

        public Employee Update(Employee employee)
        {
            return _employeeDal.Update(employee);
        }
    }
}
