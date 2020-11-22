using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenge
{
    //Greeter class
    class Greeter
    {
        public string Name;

        public void Greeting()
        {
            Console.Clear();
            Console.WriteLine($"Hello {Name}\n");
        }

        public void Farewell()
        {
            Console.Clear();
            Console.WriteLine($"Farewell {Name}\n");
        }

        public void TimeOfDay()
        {
            Console.Clear();
            double currentTime = (int)DateTime.Now.TimeOfDay.TotalMinutes;
            if(currentTime > 0 && currentTime <= (12*60))
            {
                Console.WriteLine($"Good Morning {Name}\n");
            }
            else if(currentTime > (12*60) && currentTime <= (17 * 60))
            {
                Console.WriteLine($"Good Afternoon {Name}\n");
            }
            else if(currentTime > (17*60) && currentTime <= (20 * 60))
            {
                Console.WriteLine($"Good Evening {Name}\n");
            }
            else
            {
                Console.WriteLine($"Good Night {Name}\n");
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Greeter userName = new Greeter();
            Console.Write("What is your name?  ");
            userName.Name = Console.ReadLine();
            userName.Greeting();

            Greeter secondUserName = new Greeter();
            Console.Write("Sorry I have to run and I have a terrible memory. What was your name again?  ");
            secondUserName.Name = Console.ReadLine();
            secondUserName.Farewell();

            Console.WriteLine("Press any key to find out today's current time period...");            
            Console.ReadLine();
            Greeter timeOfDay = new Greeter();
            timeOfDay.TimeOfDay();

            Console.WriteLine("*** Press any key to exit ***");
            Console.ReadLine();


        }
    }
}
