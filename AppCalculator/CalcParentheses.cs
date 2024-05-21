
namespace AppCalculator
{
    internal class CalcParentheses : CalcPart
    {
        public CalcParentheses(string input) : base(input)
        {

        }

        public override double GetOutput()
        {
            return new Calculator().Calculate(GetInput());
        }
    }
}
