using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooDio.src.Entities
{
    internal class BlackWizard : Hero
    {
        public BlackWizard(string name, int level, string type) : base(name, level, type)
        {
            Health = 70;
            Mana = 250;
        }

        public override string Attack(string attack)
        {
            return Name + " atacked with his " + attack + ".";
        }

        public override string Attack(string attack, int bonus)
        {
            if (bonus > 10)
            {
                return Name + " atacked with his super effective " + attack + " and dealt " + bonus + " bonus damage.";
            }
            else
            {
                return Name + " atacked with his weak " + attack + " and dealt " + bonus + " bonus damage.";
            }
        }

    }
}
