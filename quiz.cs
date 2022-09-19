using System;
using System.Threading;

namespace quizffs
{
    public class quiz
    {
        public static int score = 0;
        public static void Main()
        {
            score = question1.Question1(score); //calling question 1 class
            score = question2.q2(score); //calling question 2 class
            score = question3.Question3(score); //calling question 3 class
            Console.WriteLine($"Your final score is {score}");
            Console.ReadLine();
        }
    }
}
