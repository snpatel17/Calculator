using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Views
{
    interface ICalculatorView
    {
        event Func<object, EventArgs, double> ViewEvent;
        double NumberOne { get; set; }
        double Result { get; set; }
        string Operator { get; set; }
    }
}
