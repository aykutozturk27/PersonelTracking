using FluentValidation.Mvc;
using Ninject;
using SampleProject.Business.Abstract;
using SampleProject.Business.Concrete.Managers;
using SampleProject.Business.DependencyResolvers.Ninject;
using SampleProject.Core.CrossCuttingConcerns.Validation.FluentValidation;
using SampleProject.Core.Utilities.Mvc.Infrastructure;
using SampleProject.DataAccess.Abstract;
using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace SampleProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Employee employee;
            //    using (var context = newEntityModel.EFTestModel())
            //    {
            //        employee = context.Employees.FirstOrDefault();
            //        Console.WriteLine("Employee Details");
            //        Console.WriteLine("Employee Name:" + string.Join(" ", newobject[]
            //        {
            //            employee.FirstName, employee.LastName
            //}));
            //        Console.WriteLine("Employee Email Address:" + employee.EmployeeDetail.EmailAddress);
            //    }
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            IEmployeeDal _employeeService = _kernel.Get<IEmployeeDal>();
            EmployeeManager employeeManager = new EmployeeManager(_employeeService);
            var list = _employ
            foreach (var item in list)
            {
                Console.WriteLine("Department Name:" + item.Department.DepartmentName);
            }
            Console.ReadLine();
        }

    }
}
