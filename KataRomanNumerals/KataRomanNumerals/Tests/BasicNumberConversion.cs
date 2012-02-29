using NUnit.Framework;
using Solution;

namespace Tests
{
    /// <summary>
    /// Using Reference of http://www.novaroma.org/via_romana/numbers.html for tests
    /// </summary>
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
            Assert.That(RomanDigitConversion.ConvertDigit("XXII"), Is.EqualTo(22));

            Assert.That(RomanDigitConversion.ConvertDigit("XXXIV"), Is.EqualTo(34));
        }

        [Test]
        public void TheCaseOfIX_Is_9()
        {
            Assert.That(RomanDigitConversion.ConvertDigit("IX"), Is.EqualTo(9));
        }

        [Test]
        public void TheRomanNumeralL()
        {
            Assert.That(RomanDigitConversion.ConvertDigit("L"), Is.EqualTo(50));
            Assert.That(RomanDigitConversion.ConvertDigit("XL"), Is.EqualTo(40));
            Assert.That(RomanDigitConversion.ConvertDigit("XLI"), Is.EqualTo(41));
            Assert.That(RomanDigitConversion.ConvertDigit("XLVI"), Is.EqualTo(46));
            Assert.That(RomanDigitConversion.ConvertDigit("XLIX"), Is.EqualTo(49));
            Assert.That(RomanDigitConversion.ConvertDigit("LI"), Is.EqualTo(51));
            Assert.That(RomanDigitConversion.ConvertDigit("LXI"), Is.EqualTo(61));
            Assert.That(RomanDigitConversion.ConvertDigit("LXXX"), Is.EqualTo(80));
            Assert.That(RomanDigitConversion.ConvertDigit("LXXXIV"), Is.EqualTo(84));
        }
    }
}