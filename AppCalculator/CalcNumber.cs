
namespace AppCalculator
{
    internal class CalcNumber : CalcPart
    {
        public CalcNumber(string input) : base(input)
        {
        }

        public override double GetOutput()
        {
            return double.Parse(GetInput());
        }
    }
}
