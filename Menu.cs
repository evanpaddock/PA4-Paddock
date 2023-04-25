using System.Media;
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
            System.Console.WriteLine("6: Choose Music");
            System.Console.WriteLine("7: Exit Game");
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
                System.Console.WriteLine("6: Choose Music");
                System.Console.WriteLine("7: Exit Game");
                choice = Console.ReadLine();
            }
            GamePlay.RunOption(choice);
        }
        static private void TitleScreen(){
//             string titleArt = @"
// ######                                                        #####                                           ###          #     #                                                        
// #     #   ##   ##### ##### #      ######     ####  ######    #     #   ##   #      #   # #####   ####   ####  ###  ####    ##   ##   ##   ###### #       ####  ##### #####   ####  #    #
// #     #  #  #    #     #   #      #         #    # #         #        #  #  #       # #  #    # #      #    #  #  #        # # # #  #  #  #      #      #        #   #    # #    # ##  ##
// ######  #    #   #     #   #      #####     #    # #####     #       #    # #        #   #    #  ####  #    # #    ####    #  #  # #    # #####  #       ####    #   #    # #    # # ## #
// #     # ######   #     #   #      #         #    # #         #       ###### #        #   #####       # #    #          #   #     # ###### #      #           #   #   #####  #    # #    # 
// #     # #    #   #     #   #      #         #    # #         #     # #    # #        #   #      #    # #    #     #    #   #     # #    # #      #      #    #   #   #   #  #    # #    #
// ######  #    #   #     #   ###### ######     ####  #          #####  #    # ######   #   #       ####   ####       ####    #     # #    # ###### ######  ####    #   #    #  ####  #    #
// ";       
            string titleArt = "Battle of Calypso's Maelstrom";
            
            System.Console.WriteLine(titleArt);
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
                case "6":
                    return false;
                case "7":
                    return false;
                default:
                    return true; 
            }
        }
        static public bool ValidThreeMenuOption(string choice){
            switch(choice){
                case "1":
                    return false;
                case "2":
                    return false;
                default:
                    return true; 
            }
        } 
        static public bool ValidMusicMenuOption(string choice){
            switch(choice){
                case "1":
                    return false;
                case "2":
                    return false;
                case "3":
                    return false;
                case "4":
                    return false;
                default:
                    return true; 
            }
        } 
        static public string FightMenu(){
            System.Console.WriteLine("1: Attack");
            System.Console.WriteLine("2: View Characters Stats");
            string choice =  Console.ReadLine();

            while(ValidThreeMenuOption(choice)){
                Console.Clear();
                
                System.Console.WriteLine("\nInvalid choice, please choose again.");
                System.Console.WriteLine("1: Attack");
                System.Console.WriteLine("2: View Characters Stats");

                choice =  Console.ReadLine();
            }
            return choice;
        } 
        static public void PlayMusic(){
            SoundPlayer player = new SoundPlayer(@"./Music\Pirates of the Caribbean - Hes a Pirate.wav");
            player.Play();
        }
        static public void SwitchSong(string choice){
            switch(choice){
                case "1":
                SoundPlayer player1 = new SoundPlayer(@"./Music\Pirates of the Caribbean - Hes a Pirate.wav");
                    player1.PlayLooping();
                break;
                case "2":
                    SoundPlayer player2 = new SoundPlayer(@"./Music\pirate-tavern-117281.wav");
                    player2.PlayLooping();
                break;
                case "3":
                    SoundPlayer player3 = new SoundPlayer(@"./Music\buccaneer-swashbuckler-pirate-instrumental-high-seas-adventure-132858.wav");
                    player3.PlayLooping();
                break;
                case "4":
                    SoundPlayer player4 = new SoundPlayer(@"./Music\epic-cinematic-trailer-adventure-action-tense-suspenseful-122445.wav");
                    player4.PlayLooping();
                break;
            }
        } 
        static public void ChooseMusic(){
            System.Console.WriteLine("What song would you like to hear?");
            System.Console.WriteLine("1: Pirates of the Carribean Theme Song");
            System.Console.WriteLine("2: Pirate Tavern Music");
            System.Console.WriteLine("3: Buccaneer High Seas Instrumental");
            System.Console.WriteLine("4: Suspenseful Action Trailer Music");

            string choice = Console.ReadLine();
            while(ValidMusicMenuOption(choice)){
                System.Console.WriteLine("Invalid choice, please choose again.\n");
                System.Console.WriteLine("What song would you like to hear?\n");
                System.Console.WriteLine("1: Pirates of the Carribean Theme Song");
                System.Console.WriteLine("2: Pirate Tavern Music");
                System.Console.WriteLine("3: Buccaneer High Seas Instrumental");
                System.Console.WriteLine("4: Suspenseful Action Trailer Music");
                choice = Console.ReadLine();
            }
            SwitchSong(choice);
        }
    }
}