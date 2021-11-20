using FluentValidation;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Validators
{
    public class ProfileValidator : AbstractValidator<DummyProfile>
    {
        public ProfileValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("The name cannot be empty.");
        }
    }
}
