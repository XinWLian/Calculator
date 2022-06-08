using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Model
{
    public class CalculatorHistory
    {
        public string DisplayedNumber;
        public string DisplayedSequence;
        public Stack<Calculations> history = new Stack<Calculations>();
        public CalculatorHistory()
        {
            DisplayedNumber = "0";
            DisplayedSequence = "";
            history.Push(new Calculations("0", "Start"));
        }
        public void AddHistory(string number,string sequence)
        {
            if (sequence.Length == 0)
                sequence = "clear";
            history.Push(new Calculations(number, sequence));
        }
        public string Undo()
        {
            string previousNumber = "";
            if (history.Count > 0)
            {
                previousNumber = history.Pop().DisplayedNumber;
            }
            return previousNumber;
        }
    }
}
