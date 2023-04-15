using System.Text.RegularExpressions;
using PA4.Classes;

namespace PA4
{
    public class Menu
    {
        static public string DaMainMenu(){
            Console.Clear();

            DaTitle();

            System.Console.WriteLine("\nWhat game type would you like to play?\n");
            System.Console.WriteLine("1: Single Player");
            System.Console.WriteLine("2: Double Player");
            System.Console.WriteLine("3: AI vs AI");
            return Console.ReadLine();
        }
        static private void DaTitle(){
            string s = "Battle of Calypso's Maelstrom";

            //Sets text to write out in middle of console
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            System.Console.Write(s);
        }
        static public bool CanYouRead(string choice){
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
        static public void AllCharacters(){
            // Gets file names in Classes Folder/Direcdtory
            string[] characterFileNames = new DirectoryInfo("./Classes").GetFiles().Select(o => o.Name).ToArray();

            string[] allCharacters = new string[Character.maxCharacters];

            Character.allCharactersCount = 0;
            //Skips first then writes class name after breaking it by capital letter and removing the .cs
            foreach(String fileName in characterFileNames.Skip(1)){
                
                string[] fileNameByCapital = Regex.Split(fileName, @"(?<!^)(?=[A-Z])");
                fileNameByCapital[1] = fileNameByCapital[1].Substring(0,fileNameByCapital[1].Length - 3);
                
                allCharacters[Character.allCharactersCount] = $"{fileNameByCapital[0]} {fileNameByCapital[1]}";
                Character.allCharactersCount++;
            }
            Character.allCharacters = allCharacters;
        }
        static public void WriteAllCharacters(){
            for(int i = 0; i < Character.allCharactersCount; i++){
                System.Console.WriteLine(Character.allCharacters[i]);
            }
        }
    }
}