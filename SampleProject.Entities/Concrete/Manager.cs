using SampleProject.Core.Entities;

namespace SampleProject.Entities.Concrete
{
    public class Manager : BaseEntity
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Department Department { get; set; }
    }
}
