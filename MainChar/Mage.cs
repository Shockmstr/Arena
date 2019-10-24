using System;
using System.Collections.Generic;
using System.Text;

namespace MainChar
{
    public class Mage : Player
    {

        public override int BASE_HP { get => 5; set => base.BASE_HP = 5; }
        public override int BASE_DAMAGE { get => 6; set => base.BASE_DAMAGE = 6; }
    }
}
