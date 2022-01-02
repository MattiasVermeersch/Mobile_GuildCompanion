using FluentValidation;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Validators
{
    public class ProfileValidator : AbstractValidator<AccountModel>
    {
        public ProfileValidator()
        {
            RuleFor(p => p.Email)
                .NotEmpty()
                .WithMessage("The email cannot be empty.");
        }
    }
}
