using CommandToolBox;
using CommandToolBox.Helper;
using CommandToolBox.ReqAndRes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTestBox.CommandBox
{
    public class TrulyInvoker : Invoker
    {
        public Queue<string> msgs = new Queue<string>();
        public TrulyInvoker(IValidator validator, IResponseHandler responseHandler, string assemblyName, bool isCommandNeedToDI = false) 
            : base(validator, responseHandler, assemblyName, isCommandNeedToDI)
        {
        }

        public override string GetCode(string msg)
        {
            return (new Regex("(?<=\"Code\":\")(.+)(?=\",)").Match(msg).Value);
        }

        public override string Polling(int sleepTime = 100)
        {
            Thread.Sleep(sleepTime);

            string request = string.Empty;

            if (msgs.Count > 0)
            {
                return msgs.Dequeue();
            }

            return request;
        }
    }
}
