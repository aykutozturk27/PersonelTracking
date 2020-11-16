using FluentValidation;
using Ninject.Modules;
using SampleProject.Business.ValidationRules.FluentValidation;
using SampleProject.Entities.Concrete;

namespace SampleProject.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Employee>>().To<EmployeeValidator>().InSingletonScope();
        }
    }
}
