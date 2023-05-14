using CommandToolBox.Helper;
using CommandToolBox.ReqAndRes;
using ConsoleTestBox.CommandBox.ReqReObj;
using ConsoleTestBox.CommandBox.ReqReObj.One;
using Newtonsoft.Json;
using System;

namespace ConsoleTestBox.CommandBox
{
    public class ResponseHandler : IResponseHandler
    {
        public void HandlerResponse(string response)
        {
            Console.WriteLine(response);
        }
    }
}
