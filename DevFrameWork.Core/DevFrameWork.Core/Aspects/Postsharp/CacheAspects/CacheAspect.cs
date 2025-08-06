using DevFrameWork.Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;
using System;
using System.Linq;
using System.Reflection;

namespace DevFrameWork.Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheAspect : MethodInterceptionAspect
    {
        private Type _cacheType;
        private int _cacheByMinute;
        private ICacheManager _cacheManager;

        public CacheAspect(Type cacheType, int cacheByMinute=60)
        {
            _cacheType = cacheType;
            _cacheByMinute = cacheByMinute;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            // Gönderilen tyoe cacheManager türünde mi kontrolü
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("Wrong cache manager");
            }

            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);

            base.RuntimeInitialize(method);
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var methodName = string.Format("{0},{1},{2}",
                args.Method.ReflectedType.Namespace, // namespace
                args.Method.ReflectedType.Name, // class name
                args.Method.Name); // method name
            var argument = args.Arguments.ToList(); // method parameters

            var key = string.Format("{0},{1}", methodName,
                string.Join(",", argument.Select(x => x != null ? x.ToString() : "<Null>")));

            // If key is already in cache
            if (_cacheManager.IsAdd(key))
            {
                args.ReturnValue = _cacheManager.Get<object>(key);
            }
            base.OnInvoke(args);
            _cacheManager.Add(key, args.ReturnValue, _cacheByMinute);
        }
    }
}