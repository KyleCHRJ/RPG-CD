namespace PCR.SRC.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, string Health, string MagicPower, string BasicAttack, string Ability1, string Ability2)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Health = Health;
            this.MagicPower = MagicPower;
            this.BasicAttack = BasicAttack;
            this.Ability1 = Ability1;
            this.Ability2 = Ability2;
        }
        public override string Attack()
        {
            return this.BasicAttack + ": gives 200 damage.\n";
        }
        public override string Attack(int Bonus)
        {
            if (Bonus > 150)
            {
                return this.Ability2 + ": Attacking an enemy with Assassins Mark gives a " + Bonus + " bonus damage if the enemy health are lower than 50%.\n";
            }
            else
            {
                return this.Ability1 + ": Attacking with Shuriken marks your enemy, your next Blade Attack cause " + Bonus + " extra damage.\n";
            }
        }
    }
} 