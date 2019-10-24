using System;
using System.Collections.Generic;
using System.Text;

namespace MainChar
{
    public class Knight : Player
    {

        public override int BASE_HP { get => 20; set => base.BASE_HP = 20; }
        public override int BASE_DAMAGE { get => 2; set => base.BASE_DAMAGE = 2; }
    }
}
