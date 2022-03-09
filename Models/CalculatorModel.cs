using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class CalculatorModel
    {
        Operations operations = new Operations();
        public double GetResult(double numberOne, string operator_)
        {
            return operations.PerformOperation(numberOne, operator_);
        }
    }
}
