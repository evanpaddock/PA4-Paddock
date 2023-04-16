namespace PA4.Utilities
{
    public class GameUtility
    {
        static public void CreateCharacterClass(){
            Console.Clear();
            System.Console.WriteLine("What would you like the character name to be?");
            System.Console.WriteLine("You must capitalize each new word for this to impliment properly.\n");
            string characterName = Console.ReadLine();

            Console.Clear();
            System.Console.WriteLine("Who will this character receive a bonus when fighting against?");
            System.Console.WriteLine("These are all the current characters:\n");
            CharacterUtility.WriteAllCharacters();
            string attackBonusAgainst = Console.ReadLine();

            Console.Clear();
            System.Console.WriteLine("What weapon will they use?");
            System.Console.WriteLine("These are all the current weapons:\n");
            CharacterUtility.WriteAllWeapons();
            string weapon = Console.ReadLine();

            Console.Clear();
            string className = characterName.Replace(" ", "");

            CharacterUtility.CreateNewCharacterClass(className, characterName, attackBonusAgainst, weapon);
        }
        static public void CreateWeaponClass(){
            Console.Clear();
            System.Console.WriteLine("What is the name of this weapon to be?");
            System.Console.WriteLine("Examples: 'Sword', 'Pistol', 'Cannonball'");
            System.Console.WriteLine("Note: One word only please.\n");
            string weaponName = Console.ReadLine();

            Console.Clear();
            System.Console.WriteLine("What would you like the text to say when this weapon attacks?");
            System.Console.WriteLine("Example: Davy Jones 'shoots a cannonball at' Jack Sparrow");
            System.Console.WriteLine("Note: This needs to have some relevance to the weapon itself.\n");
            string attackText = Console.ReadLine();

            CharacterUtility.CreateNewWeaponClass(weaponName,attackText);
        }
    }
}