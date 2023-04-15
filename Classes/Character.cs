using PA4.Interfaces;

namespace PA4.Classes
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

    }
}