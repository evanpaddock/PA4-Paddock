using PA4.Attacks;

namespace PA4.Classes
{
    public class WillTurner : Character
    {
        public WillTurner(){
            name = "Will Turner";
            health = 100;
            attackStrength = new Random().Next(1,maxPower);
            defensivePower = new Random().Next(1,maxPower);
            attackBonusPlayer = "Davy Jones";
            Weapon = new Sword();
        }
    }
}