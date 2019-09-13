using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculate
    {
        LoggerContractsLib.ILogger _logger;
        public int Addition(int num1,int num2)
        {
           // if (_logger != null)
            //{
                this._logger.write("Add method Invoked");
            //}
            return num1 + num2;
        }

        public int Div(int num1, int num2)
        { 
                this._logger.write("Div method Invoked");

            return num1 / num2;
        }
        //as consoleLogger dependency is optional we won't do constructor injection instead 
        // we will implement property injection / setter injection (dependency is optional)
        //
        //public void SetLogger(ConsoleLoggerLib.ConsoleLogger logger)
        //{
        //    this._logger = logger;
        //}
        public LoggerContractsLib.ILogger logger { set { this._logger = value; } }
    }
}
