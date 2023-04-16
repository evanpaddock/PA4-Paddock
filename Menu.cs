using System.Text.RegularExpressions;
using PA4.Utilities;

namespace PA4
{
    public class Menu
    {
        static public void MainMenu(){
            Console.Clear();

            TitleScreen();

            System.Console.WriteLine("\nWhat would you like to do?\n");
            System.Console.WriteLine("1: Play Single Player");
            System.Console.WriteLine("2: Play Double Player");
            System.Console.WriteLine("3: Watch AI vs AI");
            System.Console.WriteLine("4: Create New Class");
            System.Console.WriteLine("5: Create New Weapon");
            string choice = Console.ReadLine();
            while(ValidMainMenuOption(choice)){
                Console.Clear();

                TitleScreen();

                System.Console.WriteLine("\nInvalid choice, please choose again.");
                 System.Console.WriteLine("\nWhat would you like to do?\n");
                System.Console.WriteLine("1: Play Single Player");
                System.Console.WriteLine("2: Play Double Player");
                System.Console.WriteLine("3: Watch AI vs AI");
                System.Console.WriteLine("4: Create New Class");
                System.Console.WriteLine("5: Create New Weapon");
                choice = Console.ReadLine();
            }
            GamePlay.RunOption(choice);
        }
        static private void TitleScreen(){
            string s = "Battle of Calypso's Maelstrom";

            //Sets text to write out in middle of console
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            System.Console.Write(s);
        }
        static public bool ValidMainMenuOption(string choice){
            switch(choice){
                case "1":
                    return false;
                case "2":
                    return false;
                case "3":
                    return false;
                case "4":
                    return false;
                case "5":
                    return false;
                default:
                    return true; 
            }
        }
        static public bool ValidFightMenuOption(string choice){
            switch(choice){
                case "1":
                    return false;
                case "2":
                    return false;
                case "3":
                    return false;
                default:
                    return true; 
            }
        } 
        static public string FightMenu(){
            System.Console.WriteLine("1: Attack");
            System.Console.WriteLine("2: Defend");
            System.Console.WriteLine("3: View Characters Stats");
            string choice =  Console.ReadLine();

            while(ValidFightMenuOption(choice)){
                System.Console.WriteLine("\nInvalid choice, please choose again.");
                System.Console.WriteLine("1: Attack");
                System.Console.WriteLine("2: Defend");
                System.Console.WriteLine("3: View Characters Stats");

                choice =  Console.ReadLine();
            }
            return choice;
        } 
    }
}