using eCommerceCore.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceCore.Validator
{
    public class LoginValidator: AbstractValidator<LoginDTO>
    {

        public LoginValidator()
        {

            RuleFor(obj => obj.Email).NotEmpty().WithMessage("Email Cannot be empty");
            RuleFor(obj => obj.Password).NotEmpty().WithMessage("Password Cannot be empty");
            
        }
    }
}
