using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityHelper
{
    public static class IContainerProviderExtensions
    {
        public static T Resolve<T>(this IContainerProvider provider)
        {
            return (T)provider.Resolve(typeof(T));
        }

        public static T Resolve<T>(this IContainerProvider provider, string name)
        {
            return (T)provider.Resolve(typeof(T), name);
        }
    }
}
