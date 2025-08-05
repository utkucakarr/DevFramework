using Castle.DynamicProxy;
using System;

namespace DevFrameWork.Core.Utilities.Interceptors
{
    // Class ve Methodlarla çalışıcak.
    // AllowMultiple = true -> Birden fazla ekleyebilirsin. Hem veri tabanına loglasın hemde bir dosyaya loglasın isteyebiliriz.
    // Inherited = true -> Inherited edilen bir noktada da bu attribute çalışsın
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; } // Öncelik. Örnek olarak -> Önce log çalışsın sonra validation gibi

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
