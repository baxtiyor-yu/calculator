namespace AppCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.DisplayMessage("kalkulyator");
            Thread.Sleep(2000);
            new Computing().StartComputing();
        }
    }
}
