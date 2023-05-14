using Autofac;
using ConsoleTestBox.CommandDIBox.ReqResObj.One;
using System;
using System.Reflection;

namespace ConsoleTestBox.CommandDIBox
{
    public class DIManager
    {
        private static IContainer _containerBuilder;
        public static IContainer GetBuilder()
        { 
            if(_containerBuilder == null)
            {
                _containerBuilder = Init();
            }
            return _containerBuilder;
        }
        private static IContainer Init()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacModuleRegister());
            
            return builder.Build();
        }
    }
    internal class AutofacModuleRegister : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // 取得目前執行App的Assembly
            this.RegisterAssemblyTypes(builder, Assembly.GetExecutingAssembly());
        }
        private void RegisterAssemblyTypes(ContainerBuilder builder, Assembly assembly)
        {
            // 註冊所有名稱為Impl結尾的物件
            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.Name.EndsWith("Impl", StringComparison.Ordinal))
                .AsImplementedInterfaces();
        }
    }
}
