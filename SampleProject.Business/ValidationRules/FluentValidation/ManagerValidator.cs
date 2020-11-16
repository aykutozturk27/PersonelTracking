using FluentValidation;
using SampleProject.Entities.Concrete;

namespace SampleProject.Business.ValidationRules.FluentValidation
{
    public class ManagerValidator : AbstractValidator<Manager>
    {
        public ManagerValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("Name is not null!");
            RuleFor(m => m.Surname).NotEmpty().WithMessage("Surname is not null!");
        }
    }
}
