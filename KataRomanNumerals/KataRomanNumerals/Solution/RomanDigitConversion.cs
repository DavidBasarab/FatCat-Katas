namespace Solution
{
    public class RomanDigitConversion : BaseDigitConversion
    {
        public static int ConvertDigit(string digit)
        {
            var convertor = new RomanDigitConversion(digit);

            return convertor.Convert();
        }

        private RomanDigitConversion(string digit)
            : base(digit) {}

        private bool ContainsX
        {
            get { return Digit.ToUpper().Contains("X"); }
        }

        protected override int Convert()
        {
            if (ContainsX) return NumeralXConversion.Convert(Digit);

            if (ContainsV) return NumeralVConversion.Convert(Digit);

            return NumeralIConversion.Convert(Digit);
        }
    }
}