using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCalculator
{
    //state based Testing : when states changes behavior will change automatically
    public class AdvanceCalculation
    {
        //state of calculator
        CalculatorModes _mode;
        public CalculatorModes currentMode { get { return this._mode; } }

        //behavior
        public void SetCalculatorMode(CalculatorModes modes)
        {
            this._mode = modes;
        }
    }
}
