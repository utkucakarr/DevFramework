using FluentValidation;

namespace DevFrameWork.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        // Entitylerimiz için object verdik. Örnek -> Product
        // Buradaki IValidator ProductValidator oluyor.
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}