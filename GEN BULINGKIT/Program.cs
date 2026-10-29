using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace gen2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== STUDENT EXAM SCORE CHECKER ===");
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter the score of Student: " + i + ": ");
                int score = int.Parse(Console.ReadLine());

                if (score >= 90 && score <= 100)
                {
                    Console.WriteLine("Status: Passed");
                    Console.WriteLine("Grade: Excellent");
                }
                else if (score >= 80 && score <= 89)
                {
                    Console.WriteLine("Status: Passed");
                    Console.WriteLine("Grade: Good");
                }
                else if (score >= 64 && score <= 74)
                {
                    Console.WriteLine("Status: Failed");
                    Console.WriteLine("Remarks: Needs Improvemets ");
                }
                else if (score >= 75 && score <= 80)
                {
                    Console.WriteLine("Status: Passed");
                    Console.WriteLine("Grade: Good");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("=== END OF PROGRAM===");

        }
    }
}
