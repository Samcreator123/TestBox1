using CommandToolBox;
using CommandToolBox.Interfaces;
using CommandToolBox.ReqAndRes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestBox.CommandBox.ReqReObj.One
{
    public class RecieverObject : IReciever
    {
        public RecieverObject() { }

        [CommandMethodCode("0001",3, false)]
        public IResponse Shout(IRequest request)
        {
            Response response = new Response();
            Request requestInstance = request as Request;

            if (requestInstance.Sound == "汪")
            {
                response.Animal = "狗";
            }
            else
            {
                response.Animal = "蛤?";
            }
            return response;
        }
    }
}
