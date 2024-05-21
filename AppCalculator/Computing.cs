
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
                var res = new Calculator().Calculate(expressionStr);
                Console.WriteLine("\nresult: {0};", res);

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
