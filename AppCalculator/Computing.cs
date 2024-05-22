
namespace AppCalculator
{
    internal class Computing
    {
        public void StartComputing()
        {
           
            while (true)
            {
                Console.Clear();
                var expressionStr = CheckInput.Checker();
                try
                {
                    var res = new Calculator().Calculate(expressionStr);
                    Console.WriteLine("\nresult: {0};", res);
                }
                catch(CalcException e)
                {
                    Console.WriteLine("\nresult: {0};", e.Message);
                }                

                Helper.DisplayMessage("Try again? (y/n)");

                if (!Console.ReadKey(false).Key.Equals(ConsoleKey.Y))
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
