using CommandToolBox;
using CommandToolBox.CommandAttribute;
using CommandToolBox.ReqAndRes;
using System;

namespace ConsoleTestBox.CommandBox.ReqReObj.One
{
    [CommandRequestCode("0001", false)]
    public class Request : IRequest
    {
        public string Code { get; set; }
        public string Sound { get; set; }
    }
}
