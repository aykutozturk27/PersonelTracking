using FluentValidation;
using SampleProject.Entities.Concrete;

namespace SampleProject.Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().WithMessage("Ad alanı boş olamaz!");
            RuleFor(e => e.LastName).NotEmpty().WithMessage("Soyad alanı boş olamaz!");
            RuleFor(e => e.Phone).NotEmpty().WithMessage("Telefon alanı boş olamaz!");
        }
    }
}
