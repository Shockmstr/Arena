using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighter
{
    class Monster
    {
        public string Name { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
    }
}
