
namespace AppCalculator
{
    abstract class CalcPart
    {
        private string input = "";
        public CalcPart(string input)
        {
            SetInput(input);
        }

        public void SetInput(string input)
        {
            this.input = input;
        }

        public string GetInput()
        {
            return input;
        }

        public abstract double GetOutput();
    }
}
