using PA4.Classes;
using PA4.Utilities;

namespace PA4
{
    public class GamePlay
    {
        static public void SinglePlayerName(ref string player1){
            System.Console.WriteLine("What is your name brave challenger?");
            player1 = Console.ReadLine();
        }
        static public void TwoPlayerNames(ref string player1, ref string player2){
            System.Console.WriteLine("\nWhat is the name of the first brave challenger?");
            player1 = Console.ReadLine();

            Console.Clear();

            System.Console.WriteLine("\nWhat is the name of the second brave challenger?");
            player2 = Console.ReadLine();
        }
        static public void RunGame(string choice){
            Console.Clear();
            switch(choice){
                case "1":
                    PvAi();
                break;
                case "2":
                    PvP();
                break;
                case "3":
                    AiVsAi();
                break;
            }
        }
        private static void PvAi()
        {
            string player1 = "";
            SinglePlayerName(ref player1);

        }
        private static void PvP()
        {   string player1 = "";
            string player2 = "";

            TwoPlayerNames(ref player1, ref player2);


        }
        private static void AiVsAi()
        {
            System.Console.WriteLine("Ai vs Ai");
        }
    }
}