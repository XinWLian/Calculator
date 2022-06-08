using Calculator.Commands;
using Calculator.Commands.Buttons.Advanced;
using Calculator.Commands.Buttons.Numerical;
using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {
        private CalculatorHistory _calculator;
        private string _displayedNumber;
        public string DisplayedNumber
        {
            get
            {
                return _displayedNumber;
            }
            set
            {
                _displayedNumber = value;
                OnPropertyChanged(nameof(DisplayedNumber));
            }
        }
        private string _displayedSequence;
        public string DisplayedSequence
        {
            get
            {
                return _displayedSequence;
            }
            set
            {
                _displayedSequence = value;
                OnPropertyChanged(nameof(DisplayedSequence));
            }
        }

        public bool operation;
        public ICommand ZeroCommand { get; }
        public ICommand OneCommand { get; }
        public ICommand TwoCommand { get; }
        public ICommand ThreeCommand { get; }
        public ICommand FourCommand { get; }
        public ICommand FiveCommand { get; }
        public ICommand SixCommand { get; }
        public ICommand SevenCommand { get; }
        public ICommand EightCommand { get; }
        public ICommand NineCommand { get; }
        public ICommand EqualsCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand SubtractCommand { get; }
        public ICommand MultiplyCommand { get; }
        public ICommand DivideCommand { get; }
        public ICommand BackspaceCommand { get; }
        public ICommand UndoCommand { get; }
        public CalculatorViewModel(CalculatorHistory calculations)
        {
            _displayedNumber = "0";
            _displayedSequence = "";
            operation = false;
            _calculator = calculations;
            ZeroCommand = new ZeroCommand( this,calculations);
            OneCommand = new OneCommand(this, calculations);
            TwoCommand = new TwoCommand(this, calculations);
            ThreeCommand = new ThreeCommand(this, calculations);
            FourCommand = new FourCommand(this, calculations);
            FiveCommand = new FiveCommand(this, calculations);
            SixCommand = new SixCommand(this, calculations);
            SevenCommand = new SevenCommand(this, calculations);
            EightCommand = new EightCommand(this, calculations);
            NineCommand = new NineCommand(this, calculations);
            AddCommand = new AddCommand(this, calculations);
            EqualsCommand = new EqualsCommand(this, calculations);
            SubtractCommand = new SubtractCommand(this, calculations);
            DivideCommand = new DivideCommand(this, calculations);
            MultiplyCommand = new MultiplyCommand(this, calculations);
            ClearCommand = new ClearCommand(this, calculations);
            BackspaceCommand = new BackspaceCommand(this, calculations);
            UndoCommand = new UndoCommand(this, calculations);
        }
    }
}
