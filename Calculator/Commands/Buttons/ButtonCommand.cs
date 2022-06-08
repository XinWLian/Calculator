using Calculator.Model;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Calculator.Commands
{
    public abstract class ButtonCommand : CommandBase
    {
        public CalculatorHistory _calculations;
        public CalculatorViewModel _calculatorViewModel;
        public ButtonCommand(CalculatorViewModel calculatorViewModel, CalculatorHistory calculations)
        {
            _calculations = calculations;
            _calculatorViewModel = calculatorViewModel; 
        }
    }
}
