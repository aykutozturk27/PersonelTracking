using SampleProject.Entities.Concrete;
using System.Collections.Generic;

namespace SampleProject.Business.Abstract
{
    public interface IManagerService
    {
        List<Manager> GetAll();
        Manager Get(int id);
        Manager Add(Manager manager);
    }
}
