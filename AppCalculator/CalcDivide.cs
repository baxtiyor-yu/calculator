
namespace AppCalculator
{
    internal class CalcDivide : CalcOperator
    {
        public override double Calculate(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new CalcException("Can't divide by zero. DivideByZeroException");
            }
            return value1 / value2;
        }

        public override char GetOperatorChar()
        {
            return '/';
        }

        public override int GetPririty()
        {
            return 6;
        }
    }
}
