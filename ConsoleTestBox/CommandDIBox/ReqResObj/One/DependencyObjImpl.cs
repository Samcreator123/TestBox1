using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestBox.CommandDIBox.ReqResObj.One
{
    public class DependencyObjImpl : IDependency
    {
        public int ProvideNumberBetweenZeroToHundred()
        {
            return new Random().Next(0, 100);
        }
    }
}
