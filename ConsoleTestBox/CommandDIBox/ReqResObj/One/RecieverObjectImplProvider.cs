using Autofac;
using CommandToolBox.Helper;
using CommandToolBox.ReqAndRes;
using System;

namespace ConsoleTestBox.CommandDIBox.ReqResObj.One
{
    public class RecieverObjectImplProvider : ICommandProvider
    {
        public Func<IRequest, IResponse> GetFunction()
        {
            var container = DIManager.GetBuilder();

            IRecieverOne obj = container.Resolve<IRecieverOne>();

            Func<IRequest, IResponse> func = (Func<IRequest, IResponse>)Delegate.CreateDelegate(typeof(Func<IRequest, IResponse>), obj, obj.GetType().GetMethod("Plus"));

            return func;
        }
    }
}
