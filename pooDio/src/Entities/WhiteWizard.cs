using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooDio.src.Entities
{
    internal class WhiteWizard : Hero
    {
        public WhiteWizard(string name, int level, string type) : base(name, level, type)
        {
            Health = 90;
            Mana = 150;
        }

        public override string Attack(string attack)
        {
            return Name + " atacked with her " + attack + ".";
        }

        public override string Attack(string attack, int bonus)
        {
            if (bonus > 10)
            {
                return Name + " atacked with her super effective " + attack + " and dealt " + bonus + " bonus damage.";
            }
            else
            {
                return Name + " atacked with her weak " + attack + " and dealt " + bonus + " bonus damage.";
            }
        }

    }
}
