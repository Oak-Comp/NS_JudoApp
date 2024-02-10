using NS_JudoApp.Helpers;
namespace NS_JudoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("North Sussex Judo");
            Console.WriteLine("by AQ Digital Solutions");

            FeesCalculator feesCalculator = new FeesCalculator();
            feesCalculator.GetPlan();

            //feesCalculator.DisplayValues<TrainingPlan>();
            
            //TrainingPlan plan = GetEnumMember<TrainingPlan>(2);
            //Console.WriteLine($"Your choice is {plan} £{plan.}");

            Console.WriteLine("\n\nProgram Terminated!");
        }


    }
}
