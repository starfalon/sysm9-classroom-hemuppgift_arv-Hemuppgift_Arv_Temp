using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board b = new Board();
            b.setUp(10);

            Player player1 = new HumanPlayer("Robert");
            Player player2 = new ComputerPlayer("Dator");

            Player aktivspelare = player1;

            while (b.getnoPins() > 0)
            {
                Console.WriteLine($"\nPinnar på bordet: {b.getnoPins()}");

                int pinsToTake = aktivspelare.takePins(b);
                b.takePins(pinsToTake);

                if (b.getnoPins() == 0)
                {
                    Console.WriteLine($"{aktivspelare.GetUserID()} tog den sista pinnen och förlorar!");
                    break;
                }

                
                aktivspelare = aktivspelare == player1 ? player2 : player1;
            }

         }

    }
}
