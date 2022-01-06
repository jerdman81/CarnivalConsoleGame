﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CarnivalConsoleGame
{
    public class ProgramUI
    {
        int tickets = 100;
        int money = 0;
        int time = 120;
        int funScore = 0;

        private readonly Dictionary<string, CarnivalGames> Games = new Dictionary<string, CarnivalGames>
        {
            {"merry-go-round", merryGoRound },
            {"basket toss", basketToss },
            {"roller coaster", rollerCoaster },
            {"ring toss", ringToss },
            {"ferris wheel", ferrisWheel },
            {"balloon dart", balloonDart },
            {"tilt-a-whirl", tiltAWhirl },
            {"baseball toss", baseballToss },
            {"ticket booth", ticketBooth }
        };

        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            CarnivalGames currentGame = ticketBooth;

            Console.Clear();
            Console.WriteLine("It's time for the county fair!\n\n" +
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

                if (command.StartsWith("go"))
                {
                    bool foundExit = false;
                    foreach (string exit in currentGame.Exits)
                    {
                        if(command.Contains(exit) &&
                            Games.ContainsKey(exit))
                        {
                            currentGame = ((Dictionary<string,CarnivalGames>) Games)[exit];
                            foundExit = true;
                            break;
                        }
                    }
                    if (!foundExit)
                    {
                        Console.WriteLine("\nYou can't get there from here.  Where do you want to go?");
                    }
                }
                else if (command.StartsWith("play") || command.StartsWith("ride"))
                {
                    if (currentGame.Time > time)
                    {
                        Console.WriteLine("You don't have enough time to do this.  Better find something else.");
                    }
                    else if (currentGame.Tickets > tickets)
                    {
                        Console.WriteLine("You don't have enough tickets to do this.  Better find something else.");
                    }
                    else
                    {
                    PlayGame(currentGame);
                    }
                }
                else if (command.StartsWith("exit"))
                {
                    ExitApplication();
                }
                else
                {
                    Console.WriteLine("\nThat isn't an option.  Try again.");
                }
                Console.WriteLine("\nPress Any Key to Continue.");
                Console.ReadKey();
            }
        }

        private void ExitApplication()
        {
            Console.Clear();
            Console.WriteLine("Hope you had a blast! Here are your final stats:");
            DisplayStats();
            Console.ReadKey();
            Environment.Exit(0);
        }

        private void DisplayStats()
        {
            Console.WriteLine($"\n\nYou have {tickets} tickets remaining.\n" +
                $"You have {time} minutes remaining.\n" +
                $"You have {funScore} Fun Points!\n\n\n");
        }

        private void PlayGame(CarnivalGames currentGame)
        {
            tickets -= currentGame.Tickets;
            time -= currentGame.Time;
            funScore += currentGame.FunPoints;
        }

            //Ticket Booth
        public static CarnivalGames ticketBooth = new CarnivalGames(
            "=========================TICKET BOOTH=====================\n\n\n" +
            "You are at the Ticket Booth.  Here you can buy tickets with any money you have and then take 4 different paths into the carnival.\n\n" +
            "This stop takes 5 minutes.\n" +
            "This stop is worth 0 Fun Points.\n\n" +
            "From here you can go to BASEBALL TOSS, BASKET TOSS, RING TOSS, BALLOON DART, or EXIT.", //splash
            new List<string> { "baseball toss", "basket toss", "ring toss", "balloon dart" }, //exits
           "Ticket Booth",  //name
           5,  //time
           0,  //tickets
           0  //fun points
           );

        //MerryGoRound
        public static readonly CarnivalGames merryGoRound = new CarnivalGames(
            "=========================MERRY-GO-ROUND=====================\n\n\n" +
            "You have reached the Merry-Go-Round.  A classic carnival ride!\n\n" +
            "This ride costs 7 tickets.\n" +
            "This ride takes 10 minutes.\n" +
            "This ride is worth 20 Fun Points!\n\n" +
            "From here you can go to BASEBALL TOSS, BASKET TOSS, or EXIT.\n\n" +
            "Do you want to RIDE MERRY-GO-ROUND or GO somewhere else?\n", //splash
            new List<string> { "baseball toss", "basket toss" }, //exits
           "Merry-Go-Round",  //name
           10,  //time
           7,  //tickets
           20  //fun points
           );

        //BaseballToss
        public static readonly CarnivalGames baseballToss = new CarnivalGames(
            "=========================BASEBALL TOSS=====================\n\n\n" +
           "Baseball Toss!  In this game, your goal is to knock over all the milk bottles in 3 throws.\n\n" +
            "This game costs 5 tickets.\n" +
            "This game takes 5 minutes.\n" +
            "This game is worth 10 Fun Points!\n\n" +
            "From here you can go to MERRY-GO-ROUND, TILT-A-WHIRL, TICKET BOOTH, or EXIT.\n\n" +
            "Do you want to PLAY GAME or GO somewhere else?\n", //splash
            new List<string> { "merry-go-round", "tilt-a-whirl", "ticket booth" }, //exits
           "Baseball Toss",  //name
           5,  //time
           5,  //tickets
           10  //fun points
           );
        //Coaster
        public static readonly CarnivalGames rollerCoaster = new CarnivalGames(
            "=========================ROLLER COASTER=====================\n\n\n" +
           "Dragon Coaster! This thing looks like it may fall apart any minute.  But the line is long and you have to ride or face ridicule from your friends!\n\n" +
            "This ride costs 10 tickets.\n" +
            "This ride takes 25 minutes.\n" +
            "This ride is worth 500 Fun Points!\n\n" +
            "From here you can go to BASKET TOSS, RING TOSS or EXIT.\n\n" +
            "Do you want to RIDE ROLLER COASTER or GO somewhere else?\n", //splash
            new List<string> { "basket toss", "ring toss" }, //exits
           "Roller Coaster",  //name
           25,  //time
           10,  //tickets
           500  //fun points
           );
        //BasketToss
        public static readonly CarnivalGames basketToss = new CarnivalGames(
            "=========================BASKET TOSS=====================\n\n\n" +
           "Basket Toss!  In this game, your goal is to get the softball to land in the basket.  You only get 3 chances.  Do you know the trick?\n\n" +
            "This game costs 5 tickets.\n" +
            "This game takes 5 minutes.\n" +
            "This game is worth 15 Fun Points!\n\n" +
            "From here you can go to ROLLER COASTER, MERRY-GO-ROUND, TICKET BOOTH, or EXIT.\n\n" +
            "Do you want to PLAY GAME or GO somewhere else?\n", //splash
            new List<string> { "roller coaster", "merry-go-round", "ticket booth" }, //exits
           "Basket Toss",  //name
           5,  //time
           5,  //tickets
           15  //fun points
           );
        //FerrisWheel
        public static readonly CarnivalGames ferrisWheel = new CarnivalGames(
            "=========================FERRIS WHEEL=====================\n\n\n" +
           "Ferris Wheel! Classic ride that is not only rickety, but very high and exhilirating!\n\n" +
            "This ride costs 12 tickets.\n" +
            "This ride takes 15 minutes\n" +
            "This ride is worth only 20 fun points!.\n\n" +
            "From here you can go to BALLOON DART, RING TOSS or EXIT.\n\n" +
            "Do you want to RIDE FERRIS WHEEL or GO somewhere else?\n", //splash
            new List<string> { "balloon dart", "ring toss" }, //exits
           "Ferris Wheel",  //name
           15,  //time
           12,  //tickets
           20  //fun points
           );
        //RingToss
        public static readonly CarnivalGames ringToss = new CarnivalGames(
            "=========================RING TOSS=====================\n\n\n" +
            "Ring-Toss! You get 3 tries to make a ringer around the bottle!\n\n" +
            "This game costs 3 tickets.\n" +
            "This game takes 5 minutes.\n" +
            "This game is worth 30 fun points!\n\n" +
            "From here you can go to FERRIS WHEEL, ROLLER COASTER, TICKET BOOTH or EXIT.\n\n" +
            "Do you want to PLAY GAME or GO somewhere else?\n", //splash
            new List<string> { "ferris wheel", "roller coaster", "ticket booth" }, //exits
           "Ring-Toss",  //name
           5,  //time
           3,  //tickets
           30  //fun points
           );
        //BalloonDart
        public static readonly CarnivalGames balloonDart = new CarnivalGames(
            "=========================BALLOON DART=====================\n\n\n" +
            "Balloon-Dart! Careful not to poke yourself as you try and pop the most balloons in the alloted 60 seconds! Must pop at least 10 balloons to win!\n\n" +
            "This game costs 3 tickets.\n" +
            "This game takes 1 minute. \n" +
            "This game is worth 50 fun points!\n\n" +
            "From here you can go to TILT-A-WHIRL, FERRIS WHEEL, TICKET BOOTH or EXIT.\n\n" +
            "Do you want to PLAY GAME or GO somewhere else?\n", //splash
            new List<string> { "tilt-a-whirl", "ferris wheel", "ticket booth" }, //exits
           "Ballon-Dart",  //name
           1,  //time
           3,  //tickets
            50  //fun points
           );
        //TiltAWhirl
        public static readonly CarnivalGames tiltAWhirl = new CarnivalGames(
            "=========================TILT-A-WHIRL=====================\n\n\n" +
           "Tilt-A-Whirl! DO NOT EAT before getting on this ride as you may find your self HURLING about.\n\n" +
           "This ride costs 5 tickets\n" +
           "This ride takes 5 minutes.\n" +
           "This ride is worth 100 fun points!\n\n" +
           "From here you can go to BASEBALL TOSS, BALLOON DART, TICKET BOOTH or EXIT.\n\n" +
           "Do you want to RIDE TILT-A-WHIRL or GO somewhere else?\n", //splash
            new List<string> { "baseball toss", "balloon dart", "ticket booth" }, //exits
           "Tilt-A-Whirl",  //name
           5,  //time
           5,  //tickets
           100  //fun points
           );
        
    }

        


    
}
