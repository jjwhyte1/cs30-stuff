using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8ball_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have 3 Questions");
            int question = 3;
            string[] responses = { "Without a Doubt.", "As I see it, yes.", "Concentrate and ask again.", "Don't count on it.", "Outlook not so good" };
            while (question > 0)
            {
                Random n = new Random();
                int r = n.Next(0, 4);
                Console.WriteLine("ask me a question and you shall recieve an answer");
                Console.ReadLine();
                Console.WriteLine(responses[r]);
                question--;
                Console.WriteLine("You have " + question + " questions left");
            }
        }
    }
}
