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
