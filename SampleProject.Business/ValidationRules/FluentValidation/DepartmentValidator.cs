using FluentValidation;
using SampleProject.Entities.Concrete;

namespace SampleProject.Business.ValidationRules.FluentValidation
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(d => d.DepartmentName).NotEmpty().WithMessage("Department name is not null!");
        }
    }
}
