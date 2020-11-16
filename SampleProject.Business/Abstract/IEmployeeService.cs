using SampleProject.Entities.Concrete;
using System.Collections.Generic;

namespace SampleProject.Business.Abstract
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        void Delete(Employee employee);
    }
}
