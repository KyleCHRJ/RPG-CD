namespace PCR.SRC.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, string Health, string MagicPower, string BasicAttack, string Ability1, string Ability2)
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
                return this.Ability2 + ": Using this ability marks a circle area in the ground for 3s, any enemies who steeped on it gets marked and recieve " + Bonus + " bonus damage from your next attack.\n";
            }
            else
            {
                return this.Ability1 + ":Casting this ability makes your next 3 Dark Attack's consume the souls of your enemies. Dealing " + Bonus + " extra damage in 4 seconds.\n";
            }



        }
    }
}