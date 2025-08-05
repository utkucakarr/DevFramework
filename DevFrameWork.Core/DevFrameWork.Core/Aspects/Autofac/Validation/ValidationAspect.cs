using Castle.DynamicProxy;
using DevFrameWork.Core.CrossCuttingConcerns.Validation.FluentValidation;
using DevFrameWork.Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Linq;

namespace DevFrameWork.Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType) // Attribute tipleri Type ile atılıyor
        {
            // defensive coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType)) // Gönderilen Validator type bir IVatilador değil ise
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }

        // Burada Onbefore methodunu eziyoruz.
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); // Reflaction -> Çalışma anında bir şeyleri çalıştırmamızı sağlıyor. New'leme işlemini çalışma anında yaptırmak istersek.
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // ProductValidator'un base type'ını bul. Onun generic argümanlarından ilkini bul. AbstractValidatora gidiyor oradaki Product'ı alıyor.
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); // İlgili methodunun parametrelerini gez eğer oradaki bir tip entityType yani product türündeyse onları validate et.
            foreach (var entity in entities)
            {
                ValidatorTool.Validate(validator, entity);
            }
        }
    }
}