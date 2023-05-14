using CommandToolBox;
using CommandToolBox.ReqAndRes;
using ConsoleTestBox.CommandBox.ReqReObj.Two;

namespace ConsoleTestBox.CommandDIBox.ReqResObj.One
{

    public class RecieverObjectImpl : IRecieverOne
    {
        private readonly IDependency _dependency;
        public RecieverObjectImpl(IDependency dependency)
        {
            _dependency = dependency;
        }
        [CommandMethodCode("0001")]
        public IResponse Plus(IRequest request)
        {
            ResponseOne response = new ResponseOne();
            RequestOne requestInstance = request as RequestOne;

            response.Sum = requestInstance.Num1 + _dependency.ProvideNumberBetweenZeroToHundred();

            return response;
        }
    }
}
