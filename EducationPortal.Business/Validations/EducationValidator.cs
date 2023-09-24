using EducationPortal.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Validations
{
    public class EducationValidator : AbstractValidator<Education>
    {
        public EducationValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez.");
            RuleFor(x => x.QuatoCount).InclusiveBetween(1, int.MaxValue).WithMessage("Kontenjan sayısı 0'dan büyük olmalıdır.");
            RuleFor(x => x.Cost).InclusiveBetween(1, int.MaxValue).WithMessage("Ücret 0'dan büyük olmalıdır.");
        }
    }
}
