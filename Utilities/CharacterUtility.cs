using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using PA4.AbstractClasses;

namespace PA4.Utilities
{
    public class CharacterUtility
    {
        static public List<string> allCharacters;
        static public List<string> allWeapons;
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
        static public void ReadAllWeapons(){
            // Gets file names in Attacks Folder/Direcdtory
            List<string> weaponFileNames = new DirectoryInfo("./Attacks").GetFiles().Select(o => o.Name).ToList();

            //initialize empty list to store names
            List<string> allweaponNames = new List<string>();

            //breaks filename into the seperate names by Capital Letter and removes the .cs before adding it to allweaponNames
            foreach(string weaponFile in weaponFileNames){
                string[] splitName = Regex.Split(weaponFile, @"(?<!^)(?=[A-Z])");

                splitName[splitName.Length - 1] = splitName[splitName.Length - 1].Substring(0,splitName[splitName.Length - 1].Length - 3);

                string weaponName = "";

                //concats each string to add proper spacing
                foreach (string substring in splitName)
                {
                    weaponName += substring;
                    if(substring != splitName[splitName.Length - 1]){
                        weaponName += " ";
                    }
                };
                allweaponNames.Add(weaponName);
            }

            allWeapons = allweaponNames;
        }
        static public void WriteAllWeapons(){
            foreach(String weapon in allWeapons){
                System.Console.WriteLine(weapon);
            }
        }
        static public void CreateNewCharacterClass(string className, string characterName, string attackBonusAgainst, string weaponType){
            weaponType = weaponType.Replace(" ", "");

            string classCode = 
            @"
using PA4.AbstractClasses;
using PA4.Attacks;
namespace PA4.Classes
{
    public class " + className + @" : Character
        {
            public " + className + @"()
            {
                name = "+ '"' + characterName + '"' + @";
                health = 100;
                attackStrength = new Random().Next(1,maxPower);
                defensivePower = new Random().Next(1,maxPower);
                attackBonusPlayer = "+ '"' + attackBonusAgainst + '"' + @";
                Weapon = new " + weaponType + @"();
            }
        }
    }
            ";

            File.WriteAllText("./CharacterClasses/" + className + ".cs", classCode);
        }
        static public void CreateNewWeaponClass(string weaponName, string attackText){
            string className = weaponName.Replace(" ", "");
            className = char.ToUpper(className[0]) + className.Substring(1);
            
            string classCode = 
            @"
using PA4.Interfaces;

namespace PA4.Attacks
{
    public class " + weaponName + @" : ISpecial
    {
        public void Attack()
        {
            System.Console.Write(" +'"' + " " + attackText + " " + '"' + @");
        }
    }
}
            ";

            File.WriteAllText("./Attacks/" + className + ".cs", classCode);
        }
        public static bool isValidWeapon(string choice){
            bool isNotValid = true;
            foreach(string weapon in CharacterUtility.allWeapons){
                if(choice == weapon){
                    isNotValid = false;
                }
            }
            return isNotValid;
        }
        public static bool IsValidCharacter(string choice){
            bool isNotValid = true;
            foreach(string character in CharacterUtility.allCharacters){
                if(choice == character){
                    isNotValid = false;
                }
            }
            return isNotValid;
        }
    }
}