using NUnit.Framework;
using Solution;

namespace Tests
{
    [TestFixture]
    public class BasicNumberConversion
    {
        [Test]
        public void TheRomanNumeralI()
        {
            Assert.That(RomanDigitConversion.ConvertDigit("I"), Is.EqualTo(1));
            Assert.That(RomanDigitConversion.ConvertDigit("II"), Is.EqualTo(2));
            Assert.That(RomanDigitConversion.ConvertDigit("III"), Is.EqualTo(3));
        }

        [Test]
        public void TheRomanNumeralV()
        {
            Assert.That(RomanDigitConversion.ConvertDigit("V"), Is.EqualTo(5));
            Assert.That(RomanDigitConversion.ConvertDigit("VI"), Is.EqualTo(6));
            Assert.That(RomanDigitConversion.ConvertDigit("VII"), Is.EqualTo(7));
            Assert.That(RomanDigitConversion.ConvertDigit("VIII"), Is.EqualTo(8));

            Assert.That(RomanDigitConversion.ConvertDigit("IV"), Is.EqualTo(4));
        }

        [Test]
        public void TheRomanNumeralX()
        {
            Assert.That(RomanDigitConversion.ConvertDigit("X"), Is.EqualTo(10));
            Assert.That(RomanDigitConversion.ConvertDigit("XI"), Is.EqualTo(11));
            Assert.That(RomanDigitConversion.ConvertDigit("XII"), Is.EqualTo(12));
            Assert.That(RomanDigitConversion.ConvertDigit("XIII"), Is.EqualTo(13));
            Assert.That(RomanDigitConversion.ConvertDigit("XIV"), Is.EqualTo(14));
            Assert.That(RomanDigitConversion.ConvertDigit("XV"), Is.EqualTo(15));
            Assert.That(RomanDigitConversion.ConvertDigit("XVI"), Is.EqualTo(16));
            Assert.That(RomanDigitConversion.ConvertDigit("XVII"), Is.EqualTo(17));
            Assert.That(RomanDigitConversion.ConvertDigit("XVIII"), Is.EqualTo(18));

            Assert.That(RomanDigitConversion.ConvertDigit("XX"), Is.EqualTo(20));
        }
    }
}