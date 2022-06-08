using Calculator.Model;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Commands.Buttons.Advanced
{
    class MultiplyCommand:ButtonCommand
    {
        public MultiplyCommand(CalculatorViewModel calculatorViewModel, CalculatorHistory calculations) : base(calculatorViewModel, calculations)
        {
        }
        public override void Execute(object parameter)
        {
            if (_calculatorViewModel.DisplayedSequence.Length == 0)
                _calculatorViewModel.DisplayedSequence += _calculatorViewModel.DisplayedNumber;
            _calculatorViewModel.DisplayedSequence += "*";
            if (_calculatorViewModel.operation == false)
                _calculatorViewModel.operation = true;
            else
                _calculatorViewModel.EqualsCommand.Execute(null);
        }
    }
}
