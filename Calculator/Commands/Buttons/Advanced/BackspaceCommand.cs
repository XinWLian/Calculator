using Calculator.Model;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Commands.Buttons.Advanced
{
    class BackspaceCommand : ButtonCommand
    {
        private HashSet<char> expressions = new HashSet<char> { '+', '-', '*', '/' };
        public BackspaceCommand(CalculatorViewModel calculatorViewModel, CalculatorHistory calculations) : base(calculatorViewModel, calculations)
        {
        }
        public override void Execute(object parameter)
        {
            string value = _calculatorViewModel.DisplayedSequence;
            if (value.Length > 0)
            {
                _calculatorViewModel.DisplayedSequence = value.Substring(0, value.Length - 1);
                if (expressions.Contains(value[value.Length - 1]))
                {
                    _calculatorViewModel.operation = false;
                }
            }
            else
                _calculatorViewModel.DisplayedSequence = "0";
        }
    }
}
