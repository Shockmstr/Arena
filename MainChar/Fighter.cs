using System;
using System.Collections.Generic;
using System.Text;

namespace MainChar
{
    public class Fighter : Player
    {

        public override int BASE_HP { get => 15; set => base.BASE_HP = 15; }
        public override int BASE_DAMAGE { get => 4; set => base.BASE_DAMAGE = 4; }
    }
}
