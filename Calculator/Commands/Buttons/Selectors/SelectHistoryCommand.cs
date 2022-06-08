using Calculator.Model;
using Calculator.Stores;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Commands.Buttons.Selectors
{
    public class SelectHistoryCommand:CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private CalculatorHistory _calculations;
        public SelectHistoryCommand(CalculatorHistory calculations, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _calculations = calculations;
        }
        public override void Execute(object parameter)
        { 
            _navigationStore.CurrentViewModel = new HistoryViewModel(_calculations);
        }
    }
}
