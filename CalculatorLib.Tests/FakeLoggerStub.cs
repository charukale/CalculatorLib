using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib.Tests
{
    class FakeLoggerStub : LoggerContractsLib.ILogger
    {
        public void write(string msg)
        {
            //throw new NotImplementedException();
        }
    }
}
