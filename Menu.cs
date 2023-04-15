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
    }
}