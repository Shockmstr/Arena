using System;
using System.Collections.Generic;
using System.Text;

namespace MainChar
{
    public class Newbie : Player
    {
        public override int BASE_HP { get => 10; set => base.BASE_HP = 10; }

        public override int BASE_DAMAGE { get => 3; set => base.BASE_DAMAGE = 3; }
    }
}
