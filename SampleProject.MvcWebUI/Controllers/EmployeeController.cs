using AutoMapper;
using SampleProject.Business.Abstract;
using SampleProject.MvcWebUI.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SampleProject.MvcWebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        private IMapper _mapper;
        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            var employee = _employeeService.GetAll();
            var employeeToReturn = _mapper.Map<List<EmployeeViewModel>>(employee);
            return View(employeeToReturn);
        }
    }
}