using Castle.DynamicProxy;
using System;

namespace DevFrameWork.Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute // Attribute yapıyoruz
    {
        protected virtual void OnBefore(IInvocation invocation) { } // invocation çalıştırmak istediğimiz methodu temsil ediyor. Örnek business metodunda ki add
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation); // method'un başında çalışır. Genellikle OnBefore ve OnException kullanılır.
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e); // Hata aldığında çalışsın.
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation); // Method başarılı olduğunda çalışsın
                }
            }
            OnAfter(invocation); // methoddan sonra çalışsın
        }
    }
}
