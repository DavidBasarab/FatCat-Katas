namespace Solution
{
    internal class NumeralVConversion : BaseDigitConversion
    {
        protected static int Value
        {
            get { return 5; }
        }

        public static int Convert(string digit)
        {
            var conversion = new NumeralVConversion(digit);

            return conversion.Convert();
        }

        private NumeralVConversion(string digit)
            : base(digit) {}

        private bool StartsWithI
        {
            get { return Digit.StartsWith("I"); }
        }

        protected override int Convert()
        {
            if (StartsWithI) return Value - FindValueWithoutV();

            return Value + FindValueWithoutV();
        }

        private int FindValueWithoutV()
        {
            return RomanDigitConversion.ConvertDigit(Digit.Remove("V"));
        }
    }
}