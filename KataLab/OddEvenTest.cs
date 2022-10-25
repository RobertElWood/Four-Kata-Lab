using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KataLab
{
    public class OddEvenTest
    {
        [Fact]
        public void TestEven()
        {
            OddEvenKata test = new OddEvenKata();

            string actual = test.OddOrEvens()[5];

            string expected = "EVEN";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestODD()
        {
            OddEvenKata test = new OddEvenKata();

            string actual = test.OddOrEvens()[0];

            string expected = "ODD";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrime()
        {
            OddEvenKata test = new OddEvenKata();

            string actual = test.OddOrEvens()[6];

            string expected = "PRIME";

            Assert.Equal(expected, actual);
        }
    }
}
