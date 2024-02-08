using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS_JudoApp
{
    /// <summary>
    /// This class is responsible for calculating the fees for the judo club.
    /// </summary>
    public class FeesCalculator
    {
        public TrainingPlan GetPlan()
        {
            Console.WriteLine("North Sussex Judo: Training Plan - Prices (£GBP)");
            Console.WriteLine();

            int planNumber = 1;

            foreach(int i in Enum.GetValues(typeof(TrainingPlan)))
            {
                Console.Write($"    {planNumber}: ");
                Console.Write($"{Enum.GetName(typeof(TrainingPlan), i)}");
                Console.Write($"{Enum.GetValues(typeof(TrainingPlan))}");

                planNumber++;
            }

            Console.WriteLine("Enter the training plan for the athlete > ");
            return TrainingPlan.Beginner;
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
