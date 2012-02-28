namespace Solution
{
    internal class NumeralIConversion : BaseDigitConversion
    {
        public static int Convert(string digit)
        {
            var conversion = new NumeralIConversion(digit);

            return conversion.Convert();
        }

        public NumeralIConversion(string digit)
            : base(digit) {}

        protected override int Convert()
        {
            return Digit.Length;
        }
    }
}