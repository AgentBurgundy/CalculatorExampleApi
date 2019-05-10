using Calculator.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        CalculatorService calcService = new CalculatorService(new AdditionService(), new SubtractionService());

        [HttpGet]
        public ActionResult<string> Landing()
        {
            return "Welcome to the Calculator App. Visit /add/{num1},{num2} to add the two numbers. Visit /subtract/{num1},{num2} to subtract the two numbers.";
        }

        [HttpGet("[action]/{num1},{num2}")]
        public ActionResult<float> Add(float num1, float num2)
        {
            return calcService.Add(num1, num2);
        }

        [HttpGet("[action]/{num1},{num2}")]
        public ActionResult<float> Subtract(float num1, float num2)
        {
            return calcService.Subtract(num1, num2);
        }
    }
}