using System;
using System.Threading;

namespace quizffs
{
    public class quiz
    {
        public static int score = 0;
        public static void Main()
        {
            question1.Question1(score); //calling question 1 class
            question2.q2(); //calling question 2 class
            question3.Question3(); //calling question 3 class
            Console.WriteLine($"Your final score is {score}");
            Console.ReadLine();
        }
    }
}
