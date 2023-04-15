using PA4.Attacks;

namespace PA4.Classes
{
    public class DavyJones : Character
    {
        public DavyJones(){
            name = "Davy Jones";
            health = 100;
            attackStrength = new Random().Next(1,maxPower);
            defensivePower = new Random().Next(1,maxPower);
            attackBonusPlayer = "Jack Sparrow";
            Weapon = new CannonBall();
        }
    }
}