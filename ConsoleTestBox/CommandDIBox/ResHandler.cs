using CommandToolBox.Helper;
using System;

namespace ConsoleTestBox.CommandDIBox
{
    public class ResHandler : IResponseHandler
    {
        public void HandlerResponse(string response)
        {
            Console.WriteLine(response);
        }
    }
}
