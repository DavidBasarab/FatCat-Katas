namespace Solution
{
    internal class NumeralVConversion : BaseDigitConversion
    {
        public static int Convert(string digit)
        {
            var conversion = new NumeralVConversion(digit);

            return conversion.Convert();
        }

        private NumeralVConversion(string digit)
            : base(digit) {}

        protected override int Convert()
        {
            if (Digit.StartsWith("I")) return 4;

            return 5 + NumeralIConversion.Convert(Digit.Remove("V"));
        }
    }
}