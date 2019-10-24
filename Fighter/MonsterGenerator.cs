using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainChar;

namespace Fighter
{
    class MonsterGenerator
    {
        static String[] names = { "Slime", "Grand Slime", "King Slime", "Hobbit", "Naive Troll", "Hoglob", "Troll", "Taskmaster", "Ogre", "Cyclops",
        "Cygnet", "Cytra", "Lizardman", "Wyvern", "Lizardman Chief", "Chieftain", "Bane", "Hallow Bane" };
        static String[] bossNames = {"Iron Slaim", "Troggolob", "Juggernaut", "Ogre Lord", "Cygnal Ultra", "Horror", "Kingliepard" };
        static String[] nemesisNames = { "Veruzian", "Jerusalem", "Unjustikate", "Revelation", "DestroyUR" };
        public static Monster GenerateMonster(Player player)
        {
            Random rand = new Random();
            int lv = player.Level + rand.Next(3);
            int maxHP = rand.Next(1, 6) * lv;
            int curHP = maxHP;
            int dam = lv + 1;
            int exp = lv * 2 + rand.Next(0, lv);
            Monster mon = new Monster
            {
                Name = names[rand.Next(0, names.Length)],
                Level = lv,
                MaxHP = maxHP,
                CurrentHP = curHP,
                Damage = dam,
                Experience = exp,
            };
            return mon;
        }

        public static Monster GenerateBoss(Player player)
        {
            Random rand = new Random();
            int lv = player.Level;
            int maxHP = rand.Next(4, 15) * lv;
            int curHP = maxHP;
            int dam = lv + 3;
            int exp = lv * rand.Next(5, 12);
            Monster mon = new Monster
            {
                Name = bossNames[rand.Next(0, bossNames.Length)] + " [BOSS]",
                Level = lv,
                MaxHP = maxHP,
                CurrentHP = curHP,
                Damage = dam,
                Experience = exp,
            };
            return mon;
        }

        public static Monster GenerateNemesis(Player player)
        {
            Random rand = new Random();
            int lv = player.Level;
            int maxHP = rand.Next(10, 60) * lv;
            int curHP = maxHP;
            int dam = lv + rand.Next(4, 7);
            int exp = lv * rand.Next(lv, lv * 5);
            Monster mon = new Monster
            {
                Name = nemesisNames[rand.Next(0, nemesisNames.Length)] + " [NEMESIS]",
                Level = lv,
                MaxHP = maxHP,
                CurrentHP = curHP,
                Damage = dam,
                Experience = exp,
            };
            return mon;
        }
    }
}
