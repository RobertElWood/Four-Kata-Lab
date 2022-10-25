using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KataLab
{
    public class DiamondKataTest
    {
        //Tests what happens if the user enters the letter 'A'.
        [Fact]
        public void TestSingleCharacterInput()
        {
            DiamondKata kata = new DiamondKata();

            string actual = kata.CreateDiamond('A')[0];

            string expected = "A";

            Assert.Equal(expected, actual);
        }

        //Checking first line output.
        [Fact]
        public void TestFirstLine()
        {
            DiamondKata kata = new DiamondKata();

            string actual = kata.CreateDiamond('B')[0];

            string expected = "·A·";

            Assert.Equal(expected, actual);
        }

        //Checking middle line output of a larger Diamond

        [Fact]
        public void TestMiddleLine()
        {
            DiamondKata kata = new DiamondKata();

            string actual = kata.CreateDiamond('E')[4];

            string expected = "E·······E";

            Assert.Equal(expected, actual);
        }

        //Checking second to last line output

        [Fact]
        public void TestNextToLast()
        {
            DiamondKata kata = new DiamondKata();

            string actual = kata.CreateDiamond('E')[7];

            string expected = "···B·B···";

            Assert.Equal(expected, actual);
        }

        //Checking the output of a larger random diamond
        [Fact]
        public void TestLargerDiamond()
        {
            DiamondKata kata = new DiamondKata();

            string actual = kata.CreateDiamond('K')[12];

            string expected = "··I···············I··";

            Assert.Equal(expected, actual);
        }

    }
}