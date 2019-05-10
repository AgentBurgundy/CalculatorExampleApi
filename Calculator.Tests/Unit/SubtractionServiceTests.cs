using Calculator.Core.Services;
using Xunit;

namespace Calculator.Tests.Unit
{
    public class SubtractionServiceTests
    {
        [Fact]
        public void CanSubtract_TwoFloats_2_1()
        {
            // Arrange
            SubtractionService subject = new SubtractionService();
            float expected = 1f;

            // Act
            float actual = subject.Evaluate(2, 1);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
