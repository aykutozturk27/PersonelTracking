using SampleProject.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace SampleProject.DataAccess.Concrete.EntityFramework.Mappings
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            ToTable(@"Department", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.DepartmentName).HasColumnName("DepartmentName");
        }
    }
}
