using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityHelper
{
    public interface IContainerProvider
    {
        object Resolve(Type type);

        object Resolve(Type type, string name);
    }
}
