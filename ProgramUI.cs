using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarnivalConsoleGame.CarnivalGames;


namespace CarnivalConsoleGame
{
    public class ProgramUI
    {
        int tickets = 100;
        int money = 0;
        int time = 120;
        int funScore = 0;

        
        public void Run()
        {
            CarnivalGames currentGame = ticketBooth;

            Console.Clear();
            Console.WriteLine("It's time for the county fair!\n" +
                "You convinced your mom to drop you off at the Midway to hang out with your friends.\n" +
                "Your mom gave you 100 tickets and will pick you up in 2 hours (120 minutes) at the Ticket Booth.\n" +
                "Have as much fun as possible before you run out of time or tickets!");
            Console.ReadKey();
            bool alive = true; //bool that indicates if you're still "alive" aka have time and tickets remaining
            while (alive)
            {
                Console.Clear();
                Console.WriteLine(currentGame.Splash);

                string command = Console.ReadLine().ToLower();

                if (command.Contains("go"))
                {
                    bool foundExit = false;
                    foreach (string exit in currentGame.Exits)
                    {
                        if(command.Contains(exit) &&
                            Games.ContainsKey(exit))
                        {
                            currentGame = Games[exit];
                            foundExit = true;
                            break;
                        }
                    }
                    if (!foundExit)
                    {
                        Console.WriteLine("\nYou can't get there from here.  Where do you want to go?");
                    }
                }
                else
                {
                    Console.WriteLine("\nThat isn't an option.  Try again.");
                }
                Console.WriteLine("\nPress Any Key to Continue.");
                Console.ReadKey();
            }




        }

        


    }
}
