using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.ViewModel
{
    public class CalculationsViewModel:ViewModelBase
    {
        private readonly Calculations _calculations;
        public string DisplayedNumber => _calculations.DisplayedNumber;
        public string PreviousSequence => _calculations.PreviousSequence;
        public double Num = 0;
        public CalculationsViewModel(Calculations calculations)
        {
            _calculations = calculations;
        }
    }
}
