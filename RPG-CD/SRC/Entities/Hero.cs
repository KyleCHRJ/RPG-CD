namespace PCR.SRC.Entities
{
    public abstract class Hero
    {
        public Hero()
        {
            Name = string.Empty;
            HeroType = string.Empty;
            BasicAttack = string.Empty;
            Health = string.Empty;
            MagicPower = string.Empty;
            Ability1 = string.Empty;
            Ability2 = string.Empty;
        }
        public Hero(string Name, int Level, string HeroType, string Health, string MagicPower, string BasicAttack, string Ability1, string Ability2)
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



        public string Name;
        public int Level;
        public string HeroType;
        public string Health;
        public string MagicPower;
        public string BasicAttack;
        public string Ability1;
        public string Ability2;


        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.Health + " " + this.MagicPower + " ";
        }

        public virtual string Attack()
        {
            return this.Ability1 + "Ataca com espada";
        }
         public virtual string Attack(int Bonus)
        {
            return this.Ability2 + "Estaca com a mao ";
        }

    }
}