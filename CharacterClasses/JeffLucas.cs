
using PA4.AbstractClasses;
using PA4.Attacks;
namespace PA4.Classes
{
    public class JeffLucas : Character
        {
            public JeffLucas()
            {
                name = "Jeff Lucas";
                health = 100;
                attackStrength = new Random().Next(1,maxPower);
                defensivePower = new Random().Next(1,maxPower);
                attackBonusPlayer = "Jack Sparrow";
                Weapon = new Guitar();
            }
        }
    }
            