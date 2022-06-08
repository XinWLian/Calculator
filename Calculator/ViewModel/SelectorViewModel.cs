using Calculator.Commands.Buttons.Advanced;
using Calculator.Commands.Buttons.Selectors;
using Calculator.Model;
using Calculator.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    public class SelectorViewModel : ViewModelBase
    {
        private CalculatorHistory _calculator;
        public ICommand SelectCalculatorCommand { get; }
        public ICommand SelectHistoryCommand { get; }
        public SelectorViewModel(CalculatorHistory calculations,NavigationStore navigationStore)
        {
            SelectCalculatorCommand = new SelectCalculatorCommand(calculations, navigationStore);
            SelectHistoryCommand = new SelectHistoryCommand(calculations,navigationStore);
            _calculator = calculations;
        }
    }
}
