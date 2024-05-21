
namespace AppCalculator
{
    internal class CalcMinus : CalcOperator
    {
        public override double Calculate(double value1, double value2)
        {
            return value1 - value2;
        }

        public override char GetOperatorChar()
        {
            return '-';
        }

        public override int GetPririty()
        {
            return 5;
        }
    }
}
