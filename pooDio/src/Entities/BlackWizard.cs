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
    }
}
