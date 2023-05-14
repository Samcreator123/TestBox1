using CommandToolBox.CommandAttribute;
using CommandToolBox.ReqAndRes;

namespace ConsoleTestBox.CommandBox.ReqReObj.Two
{
    [CommandRequestCode("0002", false)]
    public class RequestTwo : IRequest
    {
        public string Code { get; set; }
        public int Num1 { get; set; } = 0;
        public int Num2 { get; set; } = 0;
    }
}
