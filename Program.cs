using Calculator.Models;
using Calculator.Presenter;
using Calculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CalculatorModel _calculatorModel = new CalculatorModel();
            CalculatorForm _calculatorForm = new CalculatorForm();
            CalculatorPresenter _calculatorPresenter = new CalculatorPresenter(_calculatorModel, _calculatorForm);
            Application.Run(_calculatorForm);
        }
    }
}
