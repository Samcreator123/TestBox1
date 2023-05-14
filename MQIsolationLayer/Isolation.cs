
using Autofac;
using Autofac.Core;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MQIsolationLayer
{
    public class Isolation
    {
        public static Func<T, TResult> GetMethod<T, TResult>
            (string assemblyName,string objectName, string methodName)
        {

            string providerName = objectName + "Provider";

            IContainer container = GetContainer(assemblyName,providerName);

            string objectNameWithoutNamespace = objectName.Split('.')[objectName.Split('.').Length - 1];

            var obj = container.ResolveKeyed<IMQListenerApi>(objectNameWithoutNamespace);

            // get container
            var method = obj.GetType().GetMethod(methodName);
           
            var func = (Func<T, TResult>)Delegate.CreateDelegate(typeof(Func<T, TResult>), obj, method);

            return func;
        }
        private static IContainer GetContainer
            (string assemblyName,  string objectName)
        {
            Assembly assembly = Assembly.Load(assemblyName);
            
            var obj = Activator.CreateInstance(assembly.GetType(objectName));
            
            var method = obj.GetType().GetMethod("GetContainer");
            
            //var func = (IContainer)Delegate.CreateDelegate(typeof(IContainer), method);

            return (IContainer)method.Invoke(obj,null);
        }
    }
}