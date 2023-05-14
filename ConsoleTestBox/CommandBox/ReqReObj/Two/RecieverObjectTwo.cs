using CommandToolBox;
using CommandToolBox.Interfaces;
using CommandToolBox.ReqAndRes;
using ConsoleTestBox.CommandBox.ReqReObj.One;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestBox.CommandBox.ReqReObj.Two
{
    internal class RecieverObjectTwo : IReciever
    {
        public RecieverObjectTwo() { }

        [CommandMethodCode("0002",isOpen:false)]
        public IResponse Plus(IRequest request)
        {
            ResponseTwo response = new ResponseTwo();
            RequestTwo requestInstance = request as RequestTwo;

            response.Sum = requestInstance.Num1 + requestInstance.Num2;
            
            return response;
        }
    }
}
