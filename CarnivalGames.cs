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

        public CarnivalGames(string name, int time, int tickets, int funPoints)
        {
            Name = name;
            Time = time;
            Tickets = tickets;
            FunPoints = funPoints;
        }
        public string Name { get; set; }
        public int Time { get; set; }
        public int Tickets { get; set; }
        public int FunPoints { get; set; }
        // POCOS


        //Ticket Booth

        //MerryGoRound

        //BaseballToss

        //Coaster

        //BasketToss

        //FerrisWheel

        //RingToss

        //BalloonDart

        //TiltAWhirl

        //EntranceExit
    }

}
    
}
