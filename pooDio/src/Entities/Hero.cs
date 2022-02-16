namespace pooDio.src.Entities
{
    internal class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }

        public Hero(string name, int level, string type)
        {
            Name = name;
            Level = level;
            Type = type;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", " + "Level: " + Level + ", " + "Class: " + Type + ".";
        }

        public virtual string Attack(string attack)
        {
            return Name + " atacked with his " + attack + ".";
        }
    }
}
