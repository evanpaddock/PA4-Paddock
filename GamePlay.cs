using PA4.Classes;

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
        {   string player1 = "";
            string player2 = "";

            BuyOneGetOneFree(ref player1, ref player2);

            GetCharacterChoice();
        }
        private static void AiVsAi()
        {
            System.Console.WriteLine("Ai vs Ai");
        }
        private static void GetCharacterChoice(string player1 = "me", string player2 = "null"){ //string player1, string? player2
            if(player2 == null){
                System.Console.WriteLine($"Choose your character!\n"); //{player1}: 
                Menu.WriteAllCharacters();
                int choice;

                try{choice = int.Parse(Console.ReadLine());}
                catch{
                    choice = -1;
                }

                while(IsCharacter(choice)){
                    System.Console.WriteLine("Invalid choice");
                    System.Console.WriteLine($"Choose your character!\n"); //{player2}: 
                    Menu.WriteAllCharacters();

                    try{choice = int.Parse(Console.ReadLine());}
                    catch{
                        choice = -1;
                    }
                }
            }else{
                System.Console.WriteLine($"{player1}: Choose your character!\n");
                Menu.WriteAllCharacters();
                string choicePlayer1 = Console.ReadLine();

                System.Console.WriteLine($"{player2}: Choose your character!");
                System.Console.WriteLine($"You cannot choose the same character as {player1}.\n");
                Menu.AllCharacters();
                string choicePlayer2 = Console.ReadLine();

                while(choicePlayer1 == choicePlayer2 ||  IsCharacter(int.Parse(choicePlayer2))){
                    System.Console.WriteLine($"{player2}: Choose your character!");
                    System.Console.WriteLine($"You cannot choose the same character as {player1}.\n");
                    Menu.AllCharacters();
                    choicePlayer2 = Console.ReadLine();
                }
            }
        }
        static private bool IsCharacter(int characterChoice){
            if(characterChoice > 0 && characterChoice < Character.allCharactersCount){
                return false;
            }else{
                return true;
            }
        }
    }
}