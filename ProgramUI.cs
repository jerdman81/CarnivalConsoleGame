using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            CarnivalGames currentGame = CarnivalGames.ticketBooth;

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
                DisplayStats();
                Console.WriteLine(currentGame.Splash);

                string command = Console.ReadLine().ToLower();

                if (command.Contains("go"))
                {
                    bool foundExit = false;
                    foreach (string exit in currentGame.Exits)
                    {
                        if(command.Contains(exit) &&
                            CarnivalGames.Games.ContainsKey(exit))
                        {
                            currentGame = ((Dictionary<string,CarnivalGames>) CarnivalGames.Games)[exit];
                            foundExit = true;
                            break;
                        }
                    }
                    if (!foundExit)
                    {
                        Console.WriteLine("\nYou can't get there from here.  Where do you want to go?");
                    }
                }
                /* else if (command.Contains("play") || command.Contains("ride"))
                {
                    PlayGame(currentGame);
                } */
                else
                {
                    Console.WriteLine("\nThat isn't an option.  Try again.");
                }
                Console.WriteLine("\nPress Any Key to Continue.");
                Console.ReadKey();
            }
        }

        private void DisplayStats()
        {
            Console.WriteLine($"\n\nYou have {tickets} tickets remaining.\n" +
                $"You have {time} minutes remaining.\n" +
                $"You have {funScore} Fun Points!\n\n\n");
        }

        /* private void PlayGame(CarnivalGames currentGame)
        {
            switch (currentGame)
            {
                case CarnivalGames.merryGoRound:
                    tickets += CarnivalGames.merryGoRound.Tickets;
                    time += CarnivalGames.merryGoRound.Time;
                    funScore += CarnivalGames.merryGoRound.FunPoints;
                    break;
                case CarnivalGames.basketToss:
                    tickets += CarnivalGames.basketToss.Tickets;
                    time += CarnivalGames.basketToss.Time;
                    funScore += CarnivalGames.basketToss.FunPoints;
                    break;
                case CarnivalGames.rollerCoaster:
                    tickets += CarnivalGames.rollerCoaster.Tickets;
                    time += CarnivalGames.rollerCoaster.Time;
                    funScore += CarnivalGames.rollerCoaster.FunPoints;
                    break;
                case CarnivalGames.ringToss:
                    tickets += CarnivalGames.ringToss.Tickets;
                    time += CarnivalGames.ringToss.Time;
                    funScore += CarnivalGames.ringToss.FunPoints;
                    break;
                case CarnivalGames.ferrisWheel:
                    tickets += CarnivalGames.ferrisWheel.Tickets;
                    time += CarnivalGames.ferrisWheel.Time;
                    funScore += CarnivalGames.ferrisWheel.FunPoints;
                    break;
                case CarnivalGames.balloonDart:
                    tickets += CarnivalGames.balloonDart.Tickets;
                    time += CarnivalGames.balloonDart.Time;
                    funScore += CarnivalGames.balloonDart.FunPoints;
                    break;
                case CarnivalGames.tiltAWhirl:
                    tickets += CarnivalGames.tiltAWhirl.Tickets;
                    time += CarnivalGames.tiltAWhirl.Time;
                    funScore += CarnivalGames.tiltAWhirl.FunPoints;
                    break;
                case CarnivalGames.baseballToss:
                    tickets += CarnivalGames.baseballToss.Tickets;
                    time += CarnivalGames.baseballToss.Time;
                    funScore += CarnivalGames.baseballToss.FunPoints;
                    break;
            } */

     }

        


    
}
