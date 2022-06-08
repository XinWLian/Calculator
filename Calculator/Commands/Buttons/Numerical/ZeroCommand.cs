using Calculator.Model;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Commands.Buttons.Numerical
{
    class ZeroCommand : ButtonCommand
    {
        public ZeroCommand(CalculatorViewModel calculatorViewModel, CalculatorHistory calculations):base(calculatorViewModel,calculations)
        {
        }
        public override void Execute(object parameter)
        {
            _calculatorViewModel.DisplayedSequence += "0";
        }
    }
}
