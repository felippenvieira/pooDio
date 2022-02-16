namespace pooDio.src.Entities
{
    internal class Arus
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }

        public Arus(string name, int level, string type)
        {
            Name = name;
            Level = level;
            Type = type;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", " + "Level: " + Level + ", " + "Class: " + Type + ".";
        }
    }
}
