namespace PA4
{
    public class GamePlay
    {
        static public string BuyOneNoGetOneFree(){
            System.Console.WriteLine("What is your name brave challenger?");
            return Console.ReadLine();
        }
        static public void BuyOneGetOneFree(ref string player1, ref string player2){
            System.Console.WriteLine("What is the name of the first brave challenger?");
            player1 = Console.ReadLine();

            System.Console.WriteLine("What is the name of the second brave challenger?");
            player2 = Console.ReadLine();
        }
        static public void RunGame(string choice){
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
            System.Console.WriteLine("Player vs Ai");
        }
        private static void PvP()
        {
            System.Console.WriteLine("Player vs Player");
        }

        private static void AiVsAi()
        {
            System.Console.WriteLine("Ai vs Ai");
        }
    }
}