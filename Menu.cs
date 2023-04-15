using System.Text.RegularExpressions;
using PA4.Utilities;

namespace PA4
{
    public class Menu
    {
        static public void MainMenu(){
            Console.Clear();

            TitleScreen();

            System.Console.WriteLine("\nWhat game type would you like to play?\n");
            System.Console.WriteLine("1: Single Player");
            System.Console.WriteLine("2: Double Player");
            System.Console.WriteLine("3: AI vs AI");
            string choice = Console.ReadLine();
            while(ValidMainMenuOption(choice)){
                Console.Clear();

                TitleScreen();

                System.Console.WriteLine("\nInvalid choice, please choose again.");
                System.Console.WriteLine("What game type would you like to play?\n");
                System.Console.WriteLine("1: Single Player");
                System.Console.WriteLine("2: Double Player");
                System.Console.WriteLine("3: AI vs AI");
                choice = Console.ReadLine();
            }
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
                default:
                    return true; 
            }
        } 
    }
}