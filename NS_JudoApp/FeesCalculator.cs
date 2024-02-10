using NS_JudoApp.Helpers;

namespace NS_JudoApp
{
    /// <summary>
    /// This class is responsible for calculating the fees for the judo club.
    /// </summary>
    public class FeesCalculator
    {
        private readonly JudoPlan[] TrainingPlans =
        { 
            new JudoPlan { Name = "Beginner", Price = 25.00m },
            new JudoPlan { Name = "Intermediate", Price = 30.00m },
            new JudoPlan { Name = "Advanced", Price = 35.00m }
        };
        public JudoPlan GetPlan()
        {
            Console.WriteLine();
            Console.WriteLine("Training Plan - Prices (£GBP)");
            Console.WriteLine();

            int planNumber = 1;

            foreach (JudoPlan plan in TrainingPlans)
            {
                Console.Write($"    {planNumber}: ");
                Console.WriteLine(plan.ToString());

                planNumber++;
            }

            Console.WriteLine();
            Console.Write("    Select training plan number > ");
            
            int choice = ConsoleHelper.InputInt(
                "Please enter your choice > ", 1, TrainingPlans.Length);
            
            Console.WriteLine();

            Console.WriteLine($"\n   Your Choice is {TrainingPlans[choice -1].Name}");

            return TrainingPlans[choice];
        }
        
        public static void DisplayValues<T>() where T : Enum
        {
            string[] names = Enum.GetNames(typeof(T));
            int[] values = (int[])Enum.GetValues(typeof(T));

            Console.WriteLine("Select Enumeration Values:");
            Console.WriteLine();

            int number = 0;

            foreach (var value in Enum.GetValues(typeof(T)))
            {
                number++;

                Console.Write($"    {number}: ");
                Console.Write($"{Enum.GetName(typeof(T), value)}");
                Console.Write("  ");
                Console.Write($"£{Convert.ToInt32(value)}");
                Console.WriteLine();
            }
            Console.Write("\n    Enter choice > ");

            int choiceNumber = (int)ConsoleHelper.InputNumber(
                "\n Please enter your choice > ", 1, 3);

            //T member = EnumHelper.GetEnumMember<TrainingPlan>(choiceNumber - 1);

            //Console.WriteLine($"\n   Your Choice is {member}");
        }


        public void Run()
        {
            bool carryOn = true;

            while(carryOn)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the athletes name > ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    carryOn = false;
                }
                else
                {

                }
            }

        }
    }
}
