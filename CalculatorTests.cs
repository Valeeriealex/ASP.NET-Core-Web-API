using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ASP.NET_Core_Web_API
{
    [Fact]
    public class CalculatorTests
    {
        public void When1AddTo1_Return2()
        {
            var sum = new Calculator();
            var result = sut.Sum(1, 1);
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(0, -1, 1)]
        public void Calculator_AddTwoNumbers_ReturnsCorrectSum(int expectrd, int x, int y)
        {

        }
    }


}
