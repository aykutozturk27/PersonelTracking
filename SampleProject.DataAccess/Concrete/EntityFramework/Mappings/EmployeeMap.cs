using SampleProject.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace SampleProject.DataAccess.Concrete.EntityFramework.Mappings
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable(@"Employee", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.Phone).HasColumnName("Phone");

            HasRequired(x => x.Department).WithMany().HasForeignKey(x => x.DepartmentId).WillCascadeOnDelete(false);
            HasRequired(x => x.Manager).WithMany().HasForeignKey(x => x.ManagerId).WillCascadeOnDelete(false);
        }
    }
}
