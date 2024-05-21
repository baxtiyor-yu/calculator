
namespace AppCalculator
{
    abstract class CalcOperator
    {
        public abstract char GetOperatorChar();
        public abstract int GetPririty();
        public abstract double Calculate(double value1, double value2);
    }
}
