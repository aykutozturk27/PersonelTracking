using AutoMapper;
using SampleProject.Entities.Concrete;
using SampleProject.MvcWebUI.Models;

namespace SampleProject.MvcWebUI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<Manager, ManagerViewModel>();
        }
    }
}