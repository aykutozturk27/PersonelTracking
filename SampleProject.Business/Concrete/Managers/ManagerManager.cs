using SampleProject.Business.Abstract;
using SampleProject.DataAccess.Abstract;
using SampleProject.Entities.Concrete;
using System.Collections.Generic;

namespace SampleProject.Business.Concrete.Managers
{
    public class ManagerManager : IManagerService
    {
        private IManagerDal _managerDal;
        public ManagerManager(IManagerDal managerDal)
        {
            _managerDal = managerDal;
        }

        public Manager Add(Manager manager)
        {
            return _managerDal.Add(manager);
        }

        public Manager Get(int id)
        {
            return _managerDal.Get(x => x.Id == id);
        }

        public List<Manager> GetAll()
        {
            return _managerDal.GetList();
        }
    }
}
