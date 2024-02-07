namespace NS_JudoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("North Sussex Judo: Training Fees");
            Console.WriteLine("by AQ Digital Solutions");

            FeesCalculator feesCalculator = new FeesCalculator();
            feesCalculator.Run();

            Console.WriteLine("Program Terminated!");
        }
    }
}
