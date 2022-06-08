using Calculator.Model;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Commands.Buttons.Numerical
{
    class FiveCommand:ButtonCommand
    {
        public FiveCommand(CalculatorViewModel calculatorViewModel, CalculatorHistory calculations) : base(calculatorViewModel, calculations)
        {
        }
        public override void Execute(object parameter)
        {
            _calculatorViewModel.DisplayedSequence += "5";
        }
    }
}
