namespace PCR.SRC.Entities
{
    public class WhiteWitch : Hero
    {
        public WhiteWitch(string Name, int Level, string HeroType, string Health, string MagicPower, string BasicAttack, string Ability1, string Ability2)
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
                return this.Ability2 + ": Casting Moonlight Power with give a " + Bonus + " bonus on her next attack, that will be fully converted into healing. 50% for herself and 50% for her lowest ally (Extra healing are converted in shield).\n";
            }
            else
            {
                return this.Ability1 + ": Casting Light Power will give a " + Bonus  + " bonus damage to her next Attack.\n";
            }
        }
    }
}