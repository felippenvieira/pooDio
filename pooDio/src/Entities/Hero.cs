namespace pooDio.src.Entities
{
    internal abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public Hero(string name, int level, string type)
        {
            Name = name;
            Level = level;
            Type = type;
            Health = 100;
            Mana = 100;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Level: " + Level + ", Class: " + Type + ", Health: " + Health + ", Mana: " + Mana;
        }

        public virtual string Attack(string attack)
        {
            return Name + " atacked with his " + attack + ".";
        }

        public virtual string Attack(string attack, int bonus)
        {
            return Name + " atacked with his super " + attack + " and dealt " + bonus + " bonus damage.";
        }
    }
}
