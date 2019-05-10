using Calculator.Core.Services;
using Xunit;

namespace Calculator.Tests.Unit
{
    public class AdditionServiceTests
    {
        [Fact]
        public void CanAdd_TwoFloats_1_2()
        {
            // Arrange
            AdditionService subject = new AdditionService();
            float expected = 3f;

            // Act
            float actual = subject.Evaluate(1, 2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
