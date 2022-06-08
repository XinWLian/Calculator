using Calculator.Model;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Commands.Buttons.Advanced
{
    class UndoCommand:ButtonCommand
    {
        public UndoCommand(CalculatorViewModel calculatorViewModel, CalculatorHistory calculations) : base(calculatorViewModel, calculations)
        {
        }
        public override void Execute(object parameter)
        {
            _calculatorViewModel.DisplayedSequence += "";
            _calculatorViewModel.DisplayedNumber = _calculations.Undo();
        }
    }
}
