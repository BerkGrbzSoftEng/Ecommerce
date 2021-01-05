using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Core.CrossCuting.Caching;
using PostSharp.Aspects;

namespace Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheRemoveAspect:OnMethodBoundaryAspect
    {
        private string _pattern;
        private Type _cacheType;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(Type cacheType)
        {
            _cacheType = cacheType;
        }

        public CacheRemoveAspect(string pattern,Type cacheType)
        {
            _cacheType = cacheType;
            _pattern = pattern;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            //Gönderilen cache tipi ICacheManager tipinde degilse hata dön
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("Wrong Cache Manager");
            }

            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.RemoveByPattern(string.IsNullOrEmpty(_pattern)
                ? string.Format("{0}.{1}.*", args.Method.ReflectedType.Namespace, args.Method.ReflectedType.Name)
                :_pattern);
            base.OnSuccess(args);
        }
    }
}
