using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizffs
{
    internal class question3
    {
        static void Main(string[] args)
        {
            string answer;
            int score = 0;

            Console.WriteLine("Question 3");
            Console.WriteLine("Where is Otago Polytechnic?");
            answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer == "dunedin")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect, the answer was Dunedin");
            }
            Console.WriteLine($"Your score is {score}");
            Console.ReadLine();
        }
    }
}
