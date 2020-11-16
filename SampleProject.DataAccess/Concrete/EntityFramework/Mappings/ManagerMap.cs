using SampleProject.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace SampleProject.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ManagerMap : EntityTypeConfiguration<Manager>
    {
        public ManagerMap()
        {
            ToTable(@"Manager", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Surname).HasColumnName("Surname");

            HasRequired(x => x.Department).WithMany().HasForeignKey(x => x.DepartmentId).WillCascadeOnDelete(false);
        }
    }
}
