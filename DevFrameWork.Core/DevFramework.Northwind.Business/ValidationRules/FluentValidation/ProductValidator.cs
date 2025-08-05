using DevFramework.Northwind.Entities.Concerete;
using FluentValidation;

namespace DevFramework.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        // Kurallar constructure içine yazılır.
        public ProductValidator()
        {
            RuleFor(p => p.CategoryID).NotEmpty();
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 20);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryID == 1);
            RuleFor(p => p.QuantityPerUnit).NotEmpty();

            // Olmayan bir kural eklemek istediğimizde
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
            // Özel mesaj göndermek için WithMessage methodun'dan faydalanırız.

        }

        private bool StartWithA(string arg) // arg productname
        {
            return arg.StartsWith("A");
        }
    }
}
