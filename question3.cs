﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizffs
{
    public class question3
    {
        public static int Question3(int score)
        { 
            string answer;

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
            return score;
        }
    }
}
