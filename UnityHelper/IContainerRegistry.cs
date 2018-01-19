using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityHelper
{
    public interface IContainerRegistry
    {
        void RegisterInstance(Type type, object instance);

        void RegisterSingleton(Type from, Type to);

        void Register(Type from, Type to);

        void Register(Type from, Type to, string name);
    }
}
