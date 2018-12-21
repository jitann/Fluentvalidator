using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidator.Model;

namespace FluentValidator.Validator
{
    public class UserModelValidator : AbstractValidator<UserModel>
    {
        public UserModelValidator()
        {
            Initialize();
        }

        private void Initialize()
        {
            FirstNameValidator();
        }


        private void FirstNameValidator()
        {
            RuleFor(c => c.Name).NotEmpty()
                                       .WithMessage("Name should not be empty");
        }
    }
}
