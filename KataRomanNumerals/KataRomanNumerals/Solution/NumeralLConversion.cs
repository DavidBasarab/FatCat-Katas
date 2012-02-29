namespace Solution
{
    internal class NumeralLConversion : BaseDigitConversion
    {
        protected static int Value
        {
            get { return 50; }
        }

        public static int Convert(string digit)
        {
            var convertor = new NumeralLConversion(digit);

            return convertor.Convert();
        }

        private NumeralLConversion(string digit)
            : base(digit) {}

        protected override int Convert()
        {
            if (Digit.StartsWith("X")) return FindLessThan10Value();

            return Value + RomanDigitConversion.ConvertDigit(Digit.Remove("L"));
        }

        private int FindLessThan10Value()
        {
            return Value - NumeralXConversion.Value + RomanDigitConversion.ConvertDigit(Digit.Remove("XL"));
        }
    }
}