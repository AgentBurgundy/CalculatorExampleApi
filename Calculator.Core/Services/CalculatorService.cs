using Calculator.Core.Abstractions;

namespace Calculator.Core.Services
{
    public class CalculatorService
    {
        private ICalcService addService;
        private ICalcService subtractService;

        public CalculatorService(ICalcService AdditionService, ICalcService SubtractionService)
        {
            this.addService = AdditionService;
            this.subtractService = SubtractionService;
        }

        public float Add(float num1, float num2)
        {
            return addService.Evaluate(num1, num2);
        }

        public float Subtract(float num1, float num2)
        {
            return subtractService.Evaluate(num1, num2);
        }
    }
}
