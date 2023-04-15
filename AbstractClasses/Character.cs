using PA4.Interfaces;

namespace PA4.AbstractClasses
{
    public abstract class Character
    {
        public string name;
        public int health;
        public int maxPower = new Random().Next(1,101);
        public int attackStrength;
        public int defensivePower;
        public string attackBonusPlayer;
        public ISpecial Weapon;

        public void CharacterStats(){
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Health: " + health);
            System.Console.WriteLine("Max Power: " + maxPower);
            System.Console.WriteLine("Attack Strength: " + attackStrength);
            System.Console.WriteLine("Defensive Power: " + defensivePower);
            System.Console.WriteLine("Attack Bonus Against: " + attackBonusPlayer);
            System.Console.WriteLine("Weapon: " + Weapon.ToString().Substring(12));
        }
    }
}