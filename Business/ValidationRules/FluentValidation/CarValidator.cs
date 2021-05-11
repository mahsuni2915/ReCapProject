using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Decription).NotEmpty();
            RuleFor(p => p.Decription).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.BrandId == 1);
            RuleFor(p => p.Decription).Must(StardWithA).WithMessage("Ürünler A harfi ile başlamalıdır");// kendi metodumuzu böyle yazıyoruz


        }

        private bool StardWithA(string arg)// true ise kurala uygun false ise uygun değil
        {
            return arg.StartsWith("A");
        }
    }
}
