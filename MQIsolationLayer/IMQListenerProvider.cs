using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQIsolationLayer
{
    public interface IMQListenerProvider
    {
        public IContainer GetContainer();
    }
}
