using Calculator.Core.Abstractions;

namespace Calculator.Core.Services
{
    public class SubtractionService : ICalcService
    {
        public float Evaluate(float num1, float num2)
        {
            return num1 - num2;
        }
    }
}
