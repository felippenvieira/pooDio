using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooDio.src.Entities
{
    internal class Wizard : Hero
    {
        public Wizard(string name, int level, string type) : base(name, level, type)
        {
        }

        public override string Attack(string attack)
        {
            return Name + " atacked with her " + attack + ".";
        }

    }
}
