using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
   public class Operations
    {
        public double NumberOne { get; set; }
        public double Result { get; set; }
        public string Operator { get; set; }

        public double PerformOperation(double numberOne, string operator_)
        {
            NumberOne = numberOne;
            Operator = operator_;
            switch (Operator)
            {

                case "+":
                    Result = Result + NumberOne;
                    break;
                case "-":
                    Result = Result - NumberOne;
                    break;
                case "*":
                    Result = Result * NumberOne;
                    break;
                case "/":
                    if (NumberOne != 0)
                    {
                        Result = Result / NumberOne;
                    }
                    else
                    {
                        throw new Exception("You can't divide by zero!");

                    }
                    break;
                default:
                    Result = NumberOne;
                    break;
            }

            return Result;
        }

    }
}
