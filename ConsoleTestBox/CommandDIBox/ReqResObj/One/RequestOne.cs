using CommandToolBox.CommandAttribute;
using CommandToolBox.ReqAndRes;

namespace ConsoleTestBox.CommandDIBox.ReqResObj.One
{
    [CommandRequestCode("0001")]
    public class RequestOne : IRequest
    {
        public string Code { get; set; }
        public int Num1 { get; set; } = 0;
    }
}
