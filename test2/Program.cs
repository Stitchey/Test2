using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static int answer;
        static int point = 0;
        static int difficulty = 0;
        static int maxPoint = 0;
        static string restart;

        static void Main()
        {
            if (difficulty == 0)
            {
                Console.Clear();
                point = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("What difficulty?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write("1");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" - Beginner (reach 10 points)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" - Normal   (reach 20 points)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write("3");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" - Expert   (reach 50 points)");
                Program.Difficulty();
                //program.Difficulty moves you to static void Difficulty, in which you will chose your difficulty.
            }
            //start 
            Console.Clear();
            Console.WriteLine("+");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                      +");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Points: {0}/{1} ", point, maxPoint);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            //do-while loop
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("calculate:");

                //sätter random värde för one
                Random random = new Random();
                int randomNumberOne = random.Next(1, 11);
                int randomNumberTwo = random.Next(1, 11);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("{0} * {1} = ", randomNumberOne, randomNumberTwo);

                answer = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("{0} ", answer);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("is... ");
                Console.WriteLine();

                if (answer == randomNumberOne * randomNumberTwo)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Correct! ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0} * {1} is {2}...", randomNumberOne, randomNumberTwo, randomNumberOne * randomNumberTwo);
                    point++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Points: {0}/{1} ", point, maxPoint);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("(+1)");
                    Console.WriteLine();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("False! ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0} * {1} is {2}...", randomNumberOne, randomNumberTwo, randomNumberOne * randomNumberTwo);
                    point--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Points: {0}/{1} ", point, maxPoint);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("(-1)");
                    Console.WriteLine();

                }

            }
            while (point < maxPoint);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("You won!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Restart?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[Yes/No]");
            Console.ForegroundColor = ConsoleColor.White;

            restart = Console.ReadLine().ToLower();

            if (restart == "yes")
            {
                difficulty = 0;
                Program.Main();
            }

            else if (restart == "no")
            {
                Environment.Exit(0);
            }

        }

        static void Difficulty()
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.White;

            difficulty = Convert.ToInt32(Console.ReadLine());

            //if difficulty was set to Beginner
            if (difficulty == 1)
            {
                maxPoint = 10;
                Program.Main();
            }

            //if difficulty was set to Normal
            else if (difficulty == 2)
            {
                maxPoint = 20;
                Program.Main();
            }

            //if difficulty was set to Expert
            else if (difficulty == 3)
            {
                maxPoint = 50;
                Program.Main();
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("1");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(", ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("2 ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("or ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("3");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("! ");
                Program.Main();
            }
        }
    }
}
