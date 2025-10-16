using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        public string userId { get; }

       
        public Player(string player)
        {
            userId = player;
        }

        public string GetUserID()
        {
            return userId;
        }

        public abstract int takePins(Board bräde);
       
    }
}
