﻿namespace Solution
{
    public abstract class BaseDigitConversion
    {
        protected BaseDigitConversion(string digit)
        {
            Digit = digit;
        }

        public string Digit { get; set; }

        protected bool ContainsI
        {
            get { return Digit.Contains("I"); }
        }

        protected bool ContainsV
        {
            get { return Digit.ToUpper().Contains("V"); }
        }

        protected abstract int Convert();
    }
}