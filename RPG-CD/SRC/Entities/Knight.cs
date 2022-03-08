namespace PCR.SRC.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, string Health, string MagicPower, string BasicAttack, string Ability1, string Ability2)
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
                return this.Ability2 + ": After killing an enemy, Divine Justice is activated giving " + Bonus + "% of your lost health as a shield.\n";
            }
            else
            {
                return this.Ability1 + ": Will hit multiples enemies around you, giving " + Bonus  + " extra damage to all enemies nearby.\n";
            }
        }
        
    }
}