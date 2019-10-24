using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainChar
{
    public class Player
    {
        public virtual int BASE_HP { get; set; }
        public virtual int BASE_DAMAGE { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public int CurrentXP { get; set; }
        public int MaxXP { get; set; }

        public void CopyStats(Player other)
        {
            this.MaxHP = other.MaxHP;
            this.CurrentHP = this.MaxHP;
            this.Damage = other.Damage;
            this.Level = other.Level;
            this.CurrentXP = other.CurrentXP;
            this.MaxXP = other.MaxXP;
        }
    }
}
