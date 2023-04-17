
            using PA4.AbstractClasses;
            using PA4.Attacks;
            namespace PA4.Classes
            {
                public class Jim : Character
                    {
                        public Jim()
                        {
                            name = "Jim";
                            health = 100;
                            attackStrength = new Random().Next(1,maxPower);
                            defensivePower = new Random().Next(1,maxPower);
                            attackBonusPlayer = "Jeff Lucas";
                            Weapon = new SlimJim();
                        }
                    }
                }
            