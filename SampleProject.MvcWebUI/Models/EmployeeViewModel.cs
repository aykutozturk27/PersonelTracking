using SampleProject.Entities.Concrete;

namespace SampleProject.MvcWebUI.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Manager Manager { get; set; }
        public Department Department { get; set; }
    }
}