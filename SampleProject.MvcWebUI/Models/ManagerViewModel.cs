using SampleProject.Entities.Concrete;

namespace SampleProject.MvcWebUI.Models
{
    public class ManagerViewModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Department Department { get; set; }
    }
}