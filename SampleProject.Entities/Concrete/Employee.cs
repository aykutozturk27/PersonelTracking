using SampleProject.Core.Entities;

namespace SampleProject.Entities.Concrete
{
    public class Employee : BaseEntity
    {
        #region Members
        public int DepartmentId { get; set; }
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        #endregion
        public virtual Manager Manager { get; set; }
        public virtual Department Department { get; set; }
    }
}
