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
                    Menu.MainMenu();
                break;
                case "2":
                    PvP();
                    Menu.MainMenu();
                break;
                case "3":
                    AiVsAi();
                    Menu.MainMenu();
                break;
                case "4":
                    GameUtility.CreateCharacterClass();
                    System.Console.WriteLine("\nRestart the game for this class to be useable!");
                    Console.ReadKey();
                    Menu.MainMenu();
                break;
                case "5":
                    GameUtility.CreateWeaponClass();
                    System.Console.WriteLine("\nRestart the game for this weapon to be useable!");
                    Console.ReadKey();
                    Menu.MainMenu();
                break;
                case "6":
                    Menu.ChooseMusic();
                    Menu.MainMenu();
                break;
                case "7":
                    Console.Clear();
                    System.Console.WriteLine("Thank you for playing!");
                break;
            }
        }
        private static void PvAi()
        {
            string player1Name = "";
            SinglePlayerName(ref player1Name);

            System.Console.Write(player1Name + ", ");
            string player1Character = ChooseYourCharacter();

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

            System.Console.WriteLine(player1 + ",\n");
            string p1CName = ChooseYourCharacter();

            FightData.player1Name = player1;
            FightData.player1Character = CreateCharacter(p1CName);

            Console.Clear();

            System.Console.WriteLine(player2 + ",\n");
            string p2CName = ChooseYourCharacter();

            FightData.player2Name = player2;
            FightData.player2Character = CreateCharacter(p2CName);            

            Fight();

        }
        private static void AiVsAi()
        {
            FightData.player1Name = "AI";
            FightData.player2Name = "AI";

            FightData.player1Character = AiCreateCharacter();
            do{
                FightData.player2Character = AiCreateCharacter();
            }while(FightData.player1Character.name == FightData.player2Character.name);

            Fight();
        }
        private static string ChooseYourCharacter(){

            System.Console.WriteLine("Choose your character wisely!\n");
            CharacterUtility.WriteAllCharacters();

            string choice = Console.ReadLine();

            bool isNotValid = CharacterUtility.IsValidCharacter(choice);
            while(isNotValid){
                Console.Clear();
                System.Console.WriteLine("Invalid choose, please choose again.\n");
                CharacterUtility.WriteAllCharacters();

                choice = Console.ReadLine();
                isNotValid = CharacterUtility.IsValidCharacter(choice);;
            }

            return choice;

            Console.Clear();
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

            if(FightData.player1Character.attackBonusPlayer == FightData.player2Character.name){
                FightData.player1Character.attackStrength += FightData.player1Character.attackStrength / 5;
            }
            if(FightData.player2Character.attackBonusPlayer == FightData.player1Character.name){
                FightData.player2Character.attackStrength += FightData.player2Character.attackStrength / 5;
            }

            while(FightData.player1Character.health >= 0 && FightData.player2Character.health >= 0){ 

                Console.Clear();
                
                if(FightData.player1Name == "AI"){
                    choice = "1";
                    RunFightSelection(choice, FightData.player1Character, FightData.player2Character);              
                }else if(FightData.player1Character.health > 0){
                    do{
                        Console.Clear();
                        System.Console.WriteLine(FightData.player1Name + ", ");
                        choice = Menu.FightMenu();
                        RunFightSelection(choice, FightData.player1Character, FightData.player2Character);
                    }while(choice != "1");    
                }
                
                Console.Clear();

                if(FightData.player2Name == "AI"){
                    choice = "1";
                    RunFightSelection(choice, FightData.player2Character, FightData.player1Character);
                }else if(FightData.player2Character.health > 0){
                    do{
                        Console.Clear();
                        System.Console.WriteLine(FightData.player2Name + ", ");
                        choice = Menu.FightMenu();
                        RunFightSelection(choice, FightData.player2Character, FightData.player1Character);
                    }while(choice != "1");  
                }
                
            }

            Console.Clear();

            if(FightData.player1Character.health <= 0){
                System.Console.WriteLine($"PLAYER 2 WINS!");
            }else{
                System.Console.WriteLine($"PLAYER 1 WINS!");
            }

            Console.ReadKey();
        }
        private static void RunFightSelection(string choice, Character attacker, Character defender){
            Console.Clear();
           switch(choice){
            case "1":
                Attack(attacker, defender);
            break;
            case "2":
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
        private static void Attack(Character attacker, Character defender)
        {
            Console.Write(attacker.name);
            attacker.Weapon.Attack();
            System.Console.Write(defender.name + "\n");

            int damageDealt = defender.defensivePower - attacker.attackStrength;

            if(damageDealt < 0){
                System.Console.WriteLine($"That dealt {Math.Abs(damageDealt)} damage!");
                defender.health += damageDealt;
            }else{
                System.Console.WriteLine($"{defender.name} blocks the attack!");
            }
            
            Console.ReadKey();
        }
    } 
}