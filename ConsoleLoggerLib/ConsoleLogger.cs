using LoggerContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoggerLib
{
    //console logger implements/reliazes Interface
    public class ConsoleLogger : ILogger
    {
        public void write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
