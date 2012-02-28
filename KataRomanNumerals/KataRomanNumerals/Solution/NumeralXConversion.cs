namespace Solution
{
    internal class NumeralXConversion : BaseDigitConversion
    {
        public static int Convert(string digit)
        {
            var conversion = new NumeralXConversion(digit);

            return conversion.Convert();
        }

        private NumeralXConversion(string digit)
            : base(digit) {}

        private int XValue
        {
            get { return Digit.Count('X')*10; }
        }

        protected override int Convert()
        {
            if (ContainsV) return XValue + NumeralVConversion.Convert(Digit.Remove("X"));

            return XValue + NumeralIConversion.Convert(Digit.Remove("X"));
        }
    }
}