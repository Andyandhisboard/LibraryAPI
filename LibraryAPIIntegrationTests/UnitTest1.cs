using System;
using Xunit;

namespace LibraryAPIIntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // no exception means a passing test!
            
        }

        [Theory]
        [InlineData(4, 7, 11)]
        [InlineData(4, 5, 9)]
        public void CanAdd(int a, int b, int expected)
        {
            var answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}
