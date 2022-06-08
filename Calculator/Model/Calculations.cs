using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Model
{
    public class Calculations
    {
        public string DisplayedNumber { get; set; }
        public string PreviousSequence { get; set; }
        public Calculations(string value,string previousString)
        {
            DisplayedNumber = value;
            PreviousSequence = previousString;


        }

    }
}
