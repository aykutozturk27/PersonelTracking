using SampleProject.DataAccess.Concrete.EntityFramework.Mappings;
using SampleProject.Entities.Concrete;
using System.Data.Entity;

namespace SampleProject.DataAccess.Concrete.EntityFramework
{
    public class SampleProjectContext : DbContext
    {
        public SampleProjectContext() : base("SampleProjectDb")
        {
            Database.SetInitializer<SampleProjectContext>(null);
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new ManagerMap());
        }
    }
}
