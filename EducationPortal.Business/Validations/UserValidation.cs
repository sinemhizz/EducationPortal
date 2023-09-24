using EducationPortal.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Business.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("Ad boş geçilemez.");
            RuleFor(x => x.LastName).NotNull().WithMessage("Soyad boş geçilemez.");
            RuleFor(x => x.Email).NotNull().WithMessage("Email boş geçilemez.");
        }
    }
}
