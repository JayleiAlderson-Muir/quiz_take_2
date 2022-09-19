using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace quizffs
{
    public class question1
    {
        public static int Question1(int score)
        {
            const string answer1 = "elephant";
            //int score = 0;
            Console.WriteLine("Question 1");
            Console.Write("What is the world’s largest land mammal? ");
            string guess1 = Console.ReadLine();
            if (answer1 == guess1.ToLower())
            {
                Console.WriteLine("Congrats, you got question 1 correct! +1!");
                score++;
            }
            else
            {
                Console.WriteLine("That's too bad, the correct answer was: Elephant!");
            }
            Console.WriteLine($"Your score is: {score}");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(1000);
            return score;
        }
    
    }
}
