using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnivalConsoleGame
{
    public class CarnivalGames
    {
       public CarnivalGames(){}

        

        public CarnivalGames(string splash, List<string> exits, string name, int time, int tickets, int funPoints)
        {
            Splash = splash;
            Exits = exits;
            Name = name;
            Time = time;
            Tickets = tickets;
            FunPoints = funPoints;
        }
        public string Splash { get; }
        public List<string> Exits { get; }
        public string Name { get; }
        public int Time { get; }
        public int Tickets { get; }
        public int FunPoints { get; }

        // POCOS

        //Ticket Booth
        public static CarnivalGames ticketBooth = new CarnivalGames(
            "You are at the Ticket Booth.  Here you can buy tickets with any money you have and then take 4 different paths into the carnival.\n" +
            "This stop takes 5 minutes.\n" +
            "This stop is worth 0 Fun Points.\n\n" +
            "From here you can go to BASEBALL TOSS, BASKET TOSS, RING TOSS, or BALLOON DART.", //splash
            new List<string> { "baseball toss", "basket toss", "ring toss", "balloon dart" }, //exits
           "Ticket Booth",  //name
           -5,  //time
           0,  //tickets
           0  //fun points
           );

        //MerryGoRound
        public static CarnivalGames merryGoRound = new CarnivalGames(
            "You have reached the Merry-Go-Round.  A classic carnival ride!\n" +
            "This ride costs 3 tickets.\n" +
            "This ride takes 5 minutes.\n" +
            "This ride is worth 2 Fun Points!\n\n" +
            "From here you can go to BASEBALL TOSS or BASKET TOSS.", //splash
            new List<string> { "baseball toss", "basket toss"}, //exits
           "Merry-Go-Round",  //name
           -5,  //time
           -3,  //tickets
           2  //fun points
           );

        //BaseballToss
        public static CarnivalGames baseballToss = new CarnivalGames(
           "Baseball Toss!  In this game, your goal is to knock over all the milk bottles in 3 throws.\n" +
            "This game costs 3 tickets.\n" +
            "This game takes 5 minutes.\n" +
            "This game is worth 2 Fun Points!\n\n" +
            "From here you can go to MERRY-GO-ROUND, TILT-A-WHIRL, or the TICKET BOOTH.", //splash
            new List<string> { "merry-go-round", "tilt-a-whirl", "ticket booth" }, //exits
           "Baseball Toss",  //name
           -5,  //time
           -3,  //tickets
           2  //fun points
           );
        //Coaster
        public static CarnivalGames rollerCoaster = new CarnivalGames(
           "Dragon Coaster! This thing looks like it may fall apart any minute.  But the line is long and you have to ride or face ridicule from your friends!\n" +
            "This ride costs 3 tickets.\n" +
            "This ride takes 10 minutes.\n" +
            "This ride is worth 20 Fun Points!\n\n" +
            "From here you can go to BASKET TOSS or RING TOSS.", //splash
            new List<string> { "basket toss", "ring toss" }, //exits
           "Roller Coaster",  //name
           -10,  //time
           -3,  //tickets
           20  //fun points
           );
        //BasketToss
        public static CarnivalGames basketToss = new CarnivalGames(
           "Basket Toss!  In this game, your goal is to get the softball to land in the basket.  You only get 3 chances.  Do you know the trick?\n" +
            "This game costs 3 tickets.\n" +
            "This game takes 5 minutes.\n" +
            "This game is worth 2 Fun Points!\n\n" +
            "From here you can go to ROLLER COASTER, MERRY-GO-ROUND, or the TICKET BOOTH.", //splash
            new List<string> { "roller coaster", "merry-go-round", "ticket booth" }, //exits
           "Basket Toss",  //name
           -5,  //time
           -3,  //tickets
           2  //fun points
           );
        //FerrisWheel
        public static CarnivalGames ferrisWheel = new CarnivalGames(
           "Ferris Wheel! Classic ride that is not only rickety, but very high and exhilirating!\n" +
            "This ride costs 4 tickets.\n" +
            "This ride takes 10 minutes\n" +
            "This ride is worth only 2 fun points!.\n" +
            "From here you can go to BALLOON DART OR RING TOSS", //splash
            new List<string> { "balloon dart", "ring toss" }, //exits
           "Ferris Wheel",  //name
           -10,  //time
           -4,  //tickets
           2  //fun points
           );
        //RingToss
        public static CarnivalGames ringToss = new CarnivalGames(
            "Ring-Toss! You get 3 tries to make a ringer around the bottle!\n" +
            "This game costs 3 tickets.\n" +
            "This game takes 5 minutes.\n" +
            "This game is worth 3 fun points!\n" +
            "From here you can go to FERRIS WHEEL, ROLLER COASTER, OR TICKET BOOTH", //splash
            new List<string> { "ferris wheel", "roller coaster","ticket booth" }, //exits
           "Ring-Toss",  //name
           -5,  //time
           -3,  //tickets
           3  //fun points
           );
        //BalloonDart
        public static CarnivalGames balloonDart = new CarnivalGames(
            "Balloon-Dart! Careful not to poke yourself as you try and pop the most balloons in the alloted 60 seconds! Must pop at least 10 balloons to win!\n" +
            "This game costs 3 tickets.\n" +
            "This game takes 1 minute. \n" +
            "This game is worth 5 fun points!\n" +
            "From here you can go to TILT-A-WHIRL, FERRIS WHEEL OR TICKET BOOTH", //splash
            new List<string> { "tilt-a-whirl", "ferris wheel","ticket booth" }, //exits
           "Ballon-Dart",  //name
           -1,  //time
           -3,  //tickets
           5  //fun points
           );
        //TiltAWhirl
        public static CarnivalGames tiltAWhirl = new CarnivalGames(
           "Tilt-A-Whirl! DO NOT EAT before getting on this ride as you may find your self HURLING about.\n" +
           "This ride costs 5 tickets\n" +
           "This ride takes 5 minutes.\n" +
           "This ride is worth 5 fun points!\n" +
           "From here you can go to BASEBALL TOSS, BALLOON DART OR TICKET BOOTH", //splash
            new List<string> { "baseball toss", "balloon dart", "ticket booth"  }, //exits
           "Tilt-A-Whirl",  //name
           -5,  //time
           -5,  //tickets
           5  //fun points
           );
    }

}
    

