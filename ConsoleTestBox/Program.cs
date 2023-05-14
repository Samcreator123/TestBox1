using ConsoleTestBox.CommandBox;
using KafkaUtility.Impl;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ConsoleTestBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TrulyInvoker invoker = new TrulyInvoker(new Validator(),new ResponseHandler(), "ConsoleTestBox",true);
            string request3 = "{ \"Code\":\"0001\",\"Num1\":1}";

            invoker.msgs.Enqueue(request3);

            invoker.ExecuteCommands();
        }
    }

}
