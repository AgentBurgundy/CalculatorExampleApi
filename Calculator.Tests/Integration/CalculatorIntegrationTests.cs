using Calculator.Core.Services;
using Xunit;

namespace Calculator.Tests.Integration
{
    public class CalculatorIntegrationTests
    {
        [Fact]
        public void CanIntegrate_AdditionService_AndAdd_1_2()
        {
            // Arrange
            CalculatorService subject = new CalculatorService(new AdditionService(), new SubtractionService());
            float expected = 3f;

            // Act
            float actual = subject.Add(1, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanIntegrate_SubtractionService_AndSubtract_2_1()
        {
            // Arrange
            CalculatorService subject = new CalculatorService(new AdditionService(), new SubtractionService());
            float expected = 1f;

            // Act
            float actual = subject.Subtract(2, 1);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
