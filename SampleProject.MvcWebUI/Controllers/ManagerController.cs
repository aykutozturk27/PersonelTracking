using AutoMapper;
using SampleProject.Business.Abstract;
using SampleProject.MvcWebUI.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SampleProject.MvcWebUI.Controllers
{
    public class ManagerController : Controller
    {
        public IManagerService _managerService;
        private IMapper _mapper;

        public ManagerController(IManagerService managerService, IMapper mapper)
        {
            _managerService = managerService;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            var manager = _managerService.GetAll();
            var employeeToReturn = _mapper.Map<List<ManagerViewModel>>(manager);
            return View(employeeToReturn);
        }
    }
}