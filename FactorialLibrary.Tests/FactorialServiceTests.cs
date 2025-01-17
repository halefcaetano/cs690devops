using Xunit;
using FactorialLibrary; 

namespace FactorialLibrary.Tests
{
    public class FactorialServiceTests
    {
        [Fact]
        public void Test_negative()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var result = FactorialService.Factorial(-1);
            });
        }
    }
}
