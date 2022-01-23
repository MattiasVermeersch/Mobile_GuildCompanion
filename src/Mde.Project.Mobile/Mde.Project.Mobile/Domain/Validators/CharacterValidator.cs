using FluentValidation;
using Mde.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Validators
{
    public class CharacterValidator : AbstractValidator<CharacterModel>
    {
        public CharacterValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Please provide a name for your character.");

            RuleFor(c => c.Class)
                .NotEmpty()
                .WithMessage("Please select a class for you character.");

            RuleFor(c => c.Role)
                .NotEmpty()
                .WithMessage("Please select a role for your character.");

            RuleFor(c => c.Level)
                .NotEmpty()
                .WithMessage("Please provide the current level of your character.")
                .GreaterThan(0)
                .WithMessage("The level of your character must be greater than 0.")
                .LessThanOrEqualTo(60)
                .WithMessage("The level of your character must be lower or equal to 60.");

            RuleFor(c => c.ItemLevel)
                .NotEmpty()
                .WithMessage("Please provide the current item level of your character.")
                .LessThanOrEqualTo(252)
                .WithMessage("The item level cannot be greater than 252.");
        }
    }
}
