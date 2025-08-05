using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace DevFrameWork.Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList(); // Class'ın attribütelerini oku ve listeye koy.
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true); // methodun attribütelerini oku ve listeye koy.
            classAttributes.AddRange(methodAttributes);

            return classAttributes.OrderBy(x => x.Priority).ToArray(); // Çalışma sıralarını Priority'e(öncelik) değerine göre sırala.
        }
    }
}
