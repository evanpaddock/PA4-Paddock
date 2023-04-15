using PA4.Attacks;
using PA4.AbstractClasses;

namespace PA4.Classes
{
    public class JackSparrow : Character
    {
        public JackSparrow(){
            name = "Will Turner";
            health = 100;
            attackStrength = new Random().Next(1,maxPower);
            defensivePower = new Random().Next(1,maxPower);
            attackBonusPlayer = "Davy Jones";
            Weapon = new Pistol();
        }
    }
}