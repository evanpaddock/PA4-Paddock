using PA4.Interfaces;

namespace PA4.Attacks
{
    public class Pistol : ISpecial
    {
        public void Attack()
        {
            System.Console.Write(" shoots his pistol at ");
        }
    }
}