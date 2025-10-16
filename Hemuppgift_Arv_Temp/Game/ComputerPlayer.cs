using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {
        private static readonly Random random = new Random();

        public ComputerPlayer(string userId) : base(userId) { }
        public override int takePins(Board bräde)
        {
            int pins = Math.Min(2, bräde.getnoPins());
            int plock = random.Next(1, pins + 1);
            Console.WriteLine($"{userId} plockar upp {plock} pinnar.");
            return plock;
        }
    }
}
