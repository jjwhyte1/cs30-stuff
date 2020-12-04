using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have 3 Questions");
            int question = 3;
            while (question > 0) {
                Random n = new Random();
                int r = n.Next(5);
                Console.WriteLine("ask me a question and you shall recieve an answer");
                Console.ReadLine();
                Console.WriteLine(Getans(r));
                question--;
                Console.WriteLine("You have " + question +" questions left");
            } 
             Console.WriteLine("You cant ask any more questions");
            
        }
             static string Getans(int ansNum)
            {
                string response;
                switch (ansNum)
                {
                    case 0:
                        response = "Without a Doubt.";
                        break;
                    case 1:
                        response = "As I see it, yes.";
                        break;
                    case 2:
                        response = "Concentrate and ask again.";
                        break;
                    case 3:
                        response = "Don't count on it.";
                        break;
                    case 4:
                        response = "Outlook not so good";
                        break;
                    default:
                        response = "ask again";
                        break;
                }
                return response;
            }
        }
    }

