using CommandToolBox.ReqAndRes;

namespace ConsoleTestBox.CommandDIBox.ReqResObj.One
{
    public interface IRecieverOne
    {
        IResponse Plus(IRequest request);
    }
}
