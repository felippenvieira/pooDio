using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooDio.src.Entities
{
    internal class Knight : Hero
    {
        public Knight(string name, int level, string type) : base(name, level, type)
        {
        }

        public override string Attack(string attack)
        {
            return Name + " atacked with his " + attack + ".";
        }

        public override string Attack(string attack, int bonus)
        {
            return Name + " atacked with his super " + attack + " and dealt " + bonus + " bonus damage.";
        }
    }
}
