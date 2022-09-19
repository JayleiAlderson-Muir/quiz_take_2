using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizffs
{
    internal class question2
    {
        public static void Main()
        {
            int score = 0;
            Console.WriteLine("Question 2");
            Console.Write("What is the temperature -40 degrees Celsius in Fahrenheit?:  ");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            if (answer2 != -40)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("The answer was -40");
            }
            Console.WriteLine($"Your score is {score}\n");
            Console.ReadLine();
        }
    }
}
