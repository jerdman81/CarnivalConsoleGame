using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnivalConsoleGame
{
    public class ProgramUI
    {
        int tickets = 0;
        int money = 50;
        int time = 120;
        int funScore = 0;

        //Ticket Booth
        //EntranceExit

        //MerryGoRound
        public static CarnivalGames merryGoRound = new CarnivalGames(
           "Merry-Go-Round",  //name
           -5,  //time
           -3,  //tickets
           2  //fun points
           );

        //BaseballToss
        public static CarnivalGames baseballToss = new CarnivalGames(
           "Baseball Toss",  //name
           -5, //time
           -3, //tickets
           2  //fun points
           );
        //Coaster
        public static CarnivalGames rollerCoaster = new CarnivalGames(
            "Roller Coaster",  //name
            -5, //time
            -3, //tickets
            2  //fun points
            );
        //BasketToss
        public static CarnivalGames basketToss = new CarnivalGames(
           "Basket Toss",  //name
           -5, //time
           -3, //tickets
           2  //fun points
           );
        //FerrisWheel
        public static CarnivalGames ferrisWheel = new CarnivalGames(
           "Ferris Wheel",  //name
           -5, //time
           -3, //tickets
           2  //fun points
           );
        //RingToss
        public static CarnivalGames ringToss = new CarnivalGames(
            "Ring Toss",  //name
            -5, //time
            -3, //tickets
            2  //fun points
            );
        //BalloonDart
        public static CarnivalGames balloonDart = new CarnivalGames(
            "Balloon Dart",  //name
            -5, //time
            -3, //tickets
            2  //fun points
            );
        //TiltAWhirl
        public static CarnivalGames tiltAWhirl = new CarnivalGames(
           "Tilt-A-Whirl",  //name
           -5, //time
           -3, //tickets
           2  //fun points
           );

        


    }
}
