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

        public bool ContainsL
        {
            get { return Digit.ToUpper().Contains("L"); }
        }

        protected override int Convert()
        {
            if (ContainsL) return NumeralLConversion.Convert(Digit);

            if (ContainsX) return NumeralXConversion.Convert(Digit);

            if (ContainsV) return NumeralVConversion.Convert(Digit);

            return NumeralIConversion.Convert(Digit);
        }
    }
}