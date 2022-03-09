using Calculator.Models;
using Calculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Presenter
{
    class CalculatorPresenter
    {
        ICalculatorView _calculatorView;
        CalculatorModel _calculatorModel ;

        public CalculatorPresenter(CalculatorModel calculatorModel,  ICalculatorView calculatorView)
        {
            _calculatorModel = calculatorModel;
            _calculatorView = calculatorView;
            _calculatorView.ViewEvent += View_ViewEvent;
        }
        private double View_ViewEvent(object sender, EventArgs e)
        {

            return _calculatorModel.GetResult(_calculatorView.NumberOne, _calculatorView.Operator);

        }
    }
}
