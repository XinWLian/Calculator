using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Calculator.ViewModel
{
    public class HistoryViewModel:ViewModelBase
    {
        private CalculatorHistory _calculationHistory;
        private readonly ObservableCollection<CalculationsViewModel> _calculations;
        public IEnumerable<CalculationsViewModel> Calculations => _calculations;
        public HistoryViewModel(CalculatorHistory calculationsHistory)
        {
            _calculationHistory = calculationsHistory;
            _calculations = new ObservableCollection<CalculationsViewModel>();
            UpdateHistory();
        }

        private void UpdateHistory()
        {
            foreach(Calculations calculation in _calculationHistory.history)
            {
                CalculationsViewModel calculationsViewModel = new CalculationsViewModel(calculation);
                _calculations.Add(calculationsViewModel);
            }
        }
    }
}
