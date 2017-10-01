using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_NatashaOstrander
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Credit Hours: ");
            String input1 = Console.ReadLine();

            Console.WriteLine("Enter your GPA: ");
            String input2 = Console.ReadLine();

            //#2 - Loops through until an -1 is entered for GPA or Credit Hours
            do
            {
                double inputCreditHours = Convert.ToDouble(input1);
                double inputGPA = Convert.ToDouble(input2);

                if ((inputCreditHours >= 72) && (inputGPA >= 2.5))
                {
                    Console.WriteLine("Congratulations, you are eligible to graduate!");
                }
                else if (inputGPA < 2.5)
                {
                    Console.WriteLine("You need to work on your grade point average before you can graduate!");
                }
                else
                {
                    Console.WriteLine("You do not have enough hours to graduate.");
                }
                Console.WriteLine("Enter another Credit Hours or -1: ");
                input1 = Console.ReadLine();

                if (input1 != "-1")
                {
                    Console.WriteLine("Enter another GPA or -1 to quit: ");
                    input2 = Console.ReadLine();
                }
            } while ((input1 != "-1") || (input2 != "-1"));
        }
    }
}
