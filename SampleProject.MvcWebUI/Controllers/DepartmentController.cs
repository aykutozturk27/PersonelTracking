using AutoMapper;
using SampleProject.Business.Abstract;
using SampleProject.MvcWebUI.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SampleProject.MvcWebUI.Controllers
{
    public class DepartmentController : Controller
    {
        public IDepartmentService _departmentService;
        private IMapper _mapper;
        public DepartmentController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            var deparment = _departmentService.GetAll();
            var departmentToReturn = _mapper.Map<List<DepartmentViewModel>>(deparment);
            return View(departmentToReturn);
        }
    }
}