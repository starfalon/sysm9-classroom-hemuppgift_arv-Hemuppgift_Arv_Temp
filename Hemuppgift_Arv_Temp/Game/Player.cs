using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        public string UserId { get; }

       
        public Player(string player)
        {
            UserId = player;
        }

        public string GetUserID()
        {
            return UserId;
        }

        public abstract int takePins(Board bräde);
       
    }
}
