using Calculator.Model;
using Calculator.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Calculator.Commands
{
    class EqualsCommand : ButtonCommand
    {
        private HashSet<char> expressions=new HashSet<char> { '+', '-', '*','/' };
        public EqualsCommand(CalculatorViewModel calculatorViewModel, CalculatorHistory calculations) : base(calculatorViewModel, calculations)
        {
            _calculatorViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName==nameof(CalculatorViewModel.DisplayedSequence))
                OnCanExecutedChanged();
        }

        public override bool CanExecute(object parameter)
        {
            if (_calculatorViewModel.DisplayedSequence == "")
                return false;
            return true;
        }
        public override void Execute(object parameter)
        {
            string sequence = _calculatorViewModel.DisplayedSequence;
            string answer = "";
            int firstNumber;
            int secondNumber;
            int expressionLocation = -1;
            int containsAdditionalExpression = 0; //if this value is 1 then the last value is ignored in the calculations
            if (sequence.Length == 0) {
                _calculatorViewModel.DisplayedSequence = _calculatorViewModel.DisplayedNumber;
                return;
            }
            else if (expressions.Contains(sequence[sequence.Length - 1]))
                containsAdditionalExpression = 1;
            for(int i = 1; i < sequence.Length - 1; i++){//i starts at 1 because it is impossible for an expression to be leading sequence
                                                         //and we want to ignore the instance where the first value is negative
                if (expressions.Contains(sequence[i]))
                    expressionLocation = i;
            }
            if (containsAdditionalExpression == 1 && expressionLocation == sequence.Length - 2)
                answer = "Syntax Error";
            else if (expressionLocation > 0)
            {
                firstNumber = Int32.Parse(sequence.Substring(0, expressionLocation));
                secondNumber = Int32.Parse(sequence.Substring(expressionLocation + 1, sequence.Length - (expressionLocation + 1) - containsAdditionalExpression));
                switch (sequence[expressionLocation])
                {
                    case '+':
                        answer = (firstNumber + secondNumber).ToString();
                        break;
                    case '-':
                        answer = (firstNumber - secondNumber).ToString();
                        break;
                    case '*':
                        answer = (firstNumber * secondNumber).ToString();
                        break;
                    case '/':
                        answer = (firstNumber / secondNumber).ToString();
                        break;
                    default:
                        break;
                }
            }
            else if (expressionLocation < 0 && containsAdditionalExpression == 1)
                answer = "Syntax Error";
            else
                answer = sequence;
            if (answer[0] == 's')
            {
                _calculatorViewModel.operation = false;
                answer = "Syntax Error";
                _calculatorViewModel.DisplayedSequence = answer;
            }
            else if (containsAdditionalExpression == 1)
                _calculatorViewModel.DisplayedSequence = answer + sequence[sequence.Length - 1];
            else
            {
                _calculatorViewModel.DisplayedSequence = "";
                _calculatorViewModel.operation = false;
            }
            _calculations.AddHistory(answer, sequence);
            _calculatorViewModel.DisplayedNumber = answer;
        }
    }
}
