using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string userId) : base(userId) { }

        public override int takePins(Board bräde)
        {
            Console.WriteLine("Ta en eller två pinnar");
            int pins = int.Parse(Console.ReadLine());
            if (pins == 1 || pins == 2)
            {
                return pins;
            }
            else
            {
                Console.WriteLine("Du får bara ta en eller två pinnar");
                return takePins(bräde);
            }
        }
    }
}
