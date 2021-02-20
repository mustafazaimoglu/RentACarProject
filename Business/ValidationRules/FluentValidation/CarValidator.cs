using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("daily prive 0 dan büyük olmalı");
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            // when
            //RuleFor(c => c.Description).Must(StarsWithA);
        }

        //private bool StarsWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
