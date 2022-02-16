using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooDio.src.Entities
{
    internal class Ninja : Hero
    {
        public Ninja(string name, int level, string type) : base(name, level, type)
        {
            Mana = 200;
        }
    }
}
