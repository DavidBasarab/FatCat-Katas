namespace Solution
{
    internal class NumeralXConversion : BaseDigitConversion
    {
        public static int Value
        {
            get { return 10; }
        }

        public static int Convert(string digit)
        {
            var conversion = new NumeralXConversion(digit);

            return conversion.Convert();
        }

        private NumeralXConversion(string digit)
            : base(digit) {}

        private int XValue
        {
            get { return Digit.Count('X') * Value; }
        }

        protected override int Convert()
        {
            if (DoesNotStartWithX()) return XValue - FindValueWithoutX();

            return XValue + FindValueWithoutX();
        }

        private bool DoesNotStartWithX()
        {
            return !Digit.StartsWith("X");
        }

        private int FindValueWithoutX()
        {
            return RomanDigitConversion.ConvertDigit(Digit.Remove("X"));
        }
    }
}