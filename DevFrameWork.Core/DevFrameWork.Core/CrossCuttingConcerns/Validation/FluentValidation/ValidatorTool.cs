using FluentValidation;

namespace DevFrameWork.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        // Entitylerimiz için object verdik. Örnek -> Product
        // Buradaki IValidator ProductValidator oluyor.
        public static void FluentValidate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}