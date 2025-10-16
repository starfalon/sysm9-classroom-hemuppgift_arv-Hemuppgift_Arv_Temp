using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        public int noPins;

        public void setUp(int pins)
        {
            noPins += pins;
            Console.WriteLine($"Det finns {noPins} pinnar på bordet");
        }

        public void takePins(int pins)
        {
            if (pins == 1 || pins == 2)
            {
                noPins -= pins;
                Console.WriteLine($"Spelaren har tagit {pins} pinnar. Det är {noPins} pinnar kvar");
            }
            else
            {
                Console.WriteLine("Spelaren måste välja en eller två pinnar");
            }
        }

        public int getnoPins()
        {
            return noPins;
        }

    }
}
