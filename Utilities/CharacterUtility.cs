using System.Text.RegularExpressions;

namespace PA4.Utilities
{
    public class CharacterUtility
    {
        static public List<string> allCharacters;
        static public void WriteAllCharacters(){
            foreach(String character in allCharacters){
                System.Console.WriteLine(character);
            }
        }
        static public void ReadAllCharacters(){
            // Gets file names in Classes Folder/Direcdtory
            List<string> characterFileNames = new DirectoryInfo("./CharacterClasses").GetFiles().Select(o => o.Name).ToList();

            //initialize empty list to store names
            List<string> allCharacterNames = new List<string>();

            //breaks filename into the seperate names by Capital Letter and removes the .cs before adding it to allCharacterNames
            foreach(string characterFile in characterFileNames){
                string[] splitName = Regex.Split(characterFile, @"(?<!^)(?=[A-Z])");

                splitName[splitName.Length - 1] = splitName[splitName.Length - 1].Substring(0,splitName[splitName.Length - 1].Length - 3);

                string characterName = "";

                //concats each string to add proper spacing
                foreach (string substring in splitName)
                {
                    characterName += substring;
                    if(substring != splitName[splitName.Length - 1]){
                        characterName += " ";
                    }
                };
                allCharacterNames.Add(characterName);
            }

            allCharacters = allCharacterNames;
        }
    }
}