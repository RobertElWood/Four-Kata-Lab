using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KataLab
{
    public class NumberstoEngTest
    {
        [Fact]
        public void TestNullInput()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("");

            string expected = "dummy";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNonNumericInput()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("taco");

            string expected = "dummy";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestKVPSingleDigit()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("5");

            string expected = "five";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestKVPSub20()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("17");

            string expected = "seventeen";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestKVPDoubleDigit()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("55");

            string expected = "fifty-five";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestKVPTripleDigit()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("100");

            string expected = "one hundred";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestKVPTripleDigit2()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("170");

            string expected = "one hundred and seventy";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestKVPThousand()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("1000");

            string expected = "one thousand";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestKVPThousands()
        {
            NumberstoEngKata test = new NumberstoEngKata();

            string actual = test.NumbersToEng("9990");

            string expected = "nine thousand nine hundred and ninety";

            Assert.Equal(expected, actual);
        }
    }
}
