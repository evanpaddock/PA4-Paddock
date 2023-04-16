using System.Reflection;
using PA4.AbstractClasses;
using PA4.Classes;
using PA4.Utilities;

namespace PA4
{
    public class GamePlay
    {
        static public void SinglePlayerName(ref string player1){
            System.Console.WriteLine("What is your name brave challenger?");
            player1 = Console.ReadLine();
            Console.Clear();
        }
        static public void TwoPlayerNames(ref string player1, ref string player2){
            System.Console.WriteLine("\nWhat is the name of the first brave challenger?");
            player1 = Console.ReadLine();

            Console.Clear();

            System.Console.WriteLine("\nWhat is the name of the second brave challenger?");
            player2 = Console.ReadLine();

            Console.Clear();
        }
        static public void RunOption(string choice){
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
                case "4":
                    GameUtility.CreateCharacterClass();
                break;
                case "5":
                    GameUtility.CreateWeaponClass();
                break;
            }
        }
        private static void PvAi()
        {
            string player1Name = "";
            SinglePlayerName(ref player1Name);


            string player1Character = "";

            System.Console.Write(player1Name + ", ");
            ChooseYourCharacter(ref player1Character);

            Character p1Character = CreateCharacter(player1Character);

            Character aiCharacter = AiCreateCharacter();
            while(p1Character.name == aiCharacter.name){
                aiCharacter = AiCreateCharacter();
            }

            FightData.player1Name = player1Name;
            FightData.player1Character = p1Character;
            FightData.player2Name = "AI";
            FightData.player2Character = aiCharacter;

           Fight();

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
        private static void ChooseYourCharacter(ref string choice){

            System.Console.WriteLine("Choose your character wisely!\n");
            CharacterUtility.WriteAllCharacters();

            choice = Console.ReadLine();

            bool isNotValid = IsValidCharacter(choice);
            while(isNotValid){
                Console.Clear();
                System.Console.WriteLine("Invalid choose, please choose again.\n");
                CharacterUtility.WriteAllCharacters();

                choice = Console.ReadLine();
                isNotValid = IsValidCharacter(choice);
            }

            Console.Clear();
        }
        private static bool IsValidCharacter(string choice){
            bool isNotValid = true;
            foreach(string character in CharacterUtility.allCharacters){
                if(choice == character){
                    isNotValid = false;
                }
            }
            return isNotValid;
        }
        private static Character CreateCharacter(string characterName){

            string className = characterName.Replace(" ", "");

            var type = Type.GetType($"PA4.Classes.{className}");

            Character playerCharacter = (Character)Activator.CreateInstance(type);

            return playerCharacter;
        }
        private static Character AiCreateCharacter(){
            string[] characternames = CharacterUtility.allCharacters.ToArray();

            Random rnd = new Random();

            int choice = rnd.Next(0, characternames.Length);

            string chosenName = characternames[choice];

            return CreateCharacter(chosenName);
        }
        private static void Fight(){
            string choice;
            while(FightData.player1Character.health > 0 && FightData.player2Character.health > 0){
                System.Console.WriteLine(FightData.player1Name + ", choose what you will do.\n");
                choice = Menu.FightMenu();
                RunFightSelection(choice);
            }
            
        }
        private static void RunFightSelection(string choice){
            Console.Clear();
           switch(choice){
            case "1":
                Attack();
            break;
            case "2":
                Defend();
            break;
            case "3":
                Stats();
            break;
           } 
        }

        private static void Stats()
        {
            System.Console.WriteLine(FightData.player1Name + ",\n");
            FightData.player1Character.CharacterStats();

            System.Console.WriteLine("\n");

            System.Console.WriteLine(FightData.player2Name + ",\n");
            FightData.player2Character.CharacterStats();

            Console.ReadKey();

        }

        private static void Defend()
        {
            System.Console.WriteLine("Defend");
            Console.ReadKey();
        }

        private static void Attack()
        {
            System.Console.WriteLine("Attack");
            Console.ReadKey();
        }
    } 
}