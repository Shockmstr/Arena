using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainChar;
using System.Windows.Forms;

namespace Fighter
{
    public partial class Form1 : Form
    {
        Player player;
        Monster monster;
        Random rand;
        private bool bossActivated;
        private bool nemesisActivated;
        private bool isAutoClear;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initLoad();
        }

        private void initLoad()
        {
            player = new Newbie
            {
                CurrentHP = 10,
                MaxHP = 10,
                Damage = 3,
                Level = 1,
                CurrentXP = 0,
                MaxXP = 8,
            };
            HPBarP.Value = player.CurrentHP;
            HPBarP.Maximum = player.MaxHP;
            //HPBarP.Style = ProgressBarStyle.Continuous;
            lbPlayerHP.Text = HPBarP.Value + "/" + HPBarP.Maximum;
            lbLVP.Text = player.Level.ToString();
            lbExp.Text = player.CurrentXP + "/" + player.MaxXP;
            lbDMG.Text = player.Damage.ToString() + " - " + (player.Damage + (player.Level + 1)) ;
            lbClass.Text = typeof(Newbie).Name;

            monster = new Monster
            {
                Name = "Slime",
                CurrentHP = 5,
                MaxHP = 5,
                Damage = 2,
                Level = 1,
                Experience = 4,
            };
            label3.Text = monster.Name;
            HPBarM.Value = monster.CurrentHP;
            HPBarM.Maximum = monster.MaxHP;
            //HPBarM.Style = ProgressBarStyle.Continuous;
            lbMonsterHP.Text = HPBarM.Value + "/" + HPBarM.Maximum;
            lbLVM.Text = monster.Level + "";
            lbMonsterDMG.Text = monster.Damage + " - " + (monster.Damage + monster.Level);

            rand = new Random();
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\hieudbui\Desktop\Legendary.wav");            
            //sound.PlayLooping();

        }
 
        private void CheckActivated()
        {
            if (bossActivated == true)
                bossActivated = false;
            if (nemesisActivated == true)
                nemesisActivated = false;
        }

        private void UpdateHPLabel(bool isPlayer)
        {
            if (isPlayer)
            {
                lbPlayerHP.Text = player.CurrentHP + "/" + player.MaxHP;
            }
            else
            {
                lbMonsterHP.Text = monster.CurrentHP + "/" + monster.MaxHP;
            }
        }
        private void UpdateHPBar(bool isPlayer, int value)
        {
            if (isPlayer)
            {
                if (HPBarP.Value >= value)
                {
                    HPBarP.Value -= value;                 
                }
                else
                {
                    HPBarP.Value = 0;
                }
                UpdateHPLabel(isPlayer);
            }
            else
            {
                if (HPBarM.Value >= value)
                {
                    HPBarM.Value -= value;
                }
                else
                {
                    HPBarM.Value = 0;
                }
                UpdateHPLabel(isPlayer);
            }
        }

        private void UpdateHPBarHealing(bool isPlayer, int value)
        {
            if (isPlayer)
            {
                if ((HPBarP.Value + value) <= HPBarP.Maximum)
                {
                    HPBarP.Value += value;
                }
                else
                {
                    HPBarP.Value = player.MaxHP;
                }
                UpdateHPLabel(isPlayer);
            }
            else
            {
                if ((HPBarM.Value + value) <= HPBarM.Maximum)
                {
                    HPBarM.Value += value;
                }
                else
                {
                    HPBarM.Value = monster.MaxHP;
                }
                UpdateHPLabel(isPlayer);
            }
        }
        private void UpdateNewMonster()
        {
            label3.Text = monster.Name;
            HPBarM.Maximum = monster.MaxHP;
            HPBarM.Value = monster.CurrentHP;         
            lbMonsterHP.Text = HPBarM.Value + "/" + HPBarM.Maximum;
            lbLVM.Text = monster.Level + "";
            lbMonsterDMG.Text = monster.Damage + " - " + (monster.Damage + monster.Level);
        }

        private void ChangeClasses()
        {
            ChangeClassForm changeClassForm = new ChangeClassForm();
            DialogResult res = changeClassForm.ShowDialog(this);
            Player old = new Player();
            old.CopyStats(player);
            if (res == DialogResult.OK) // Knight
            {
                player = new Knight();
                player.CopyStats(old);
                player.Damage = player.BASE_DAMAGE + player.Level;
                lbClass.Text = typeof(Knight).Name;
            }
            else if (res == DialogResult.Cancel) // Fighter
            {
                player = new MainChar.Fighter();
                player.CopyStats(old);
                player.Damage = player.BASE_DAMAGE + player.Level;
                lbClass.Text = typeof(MainChar.Fighter).Name;
            }
            else if (res == DialogResult.Yes) // Mage
            {
                player = new Mage();
                player.CopyStats(old);
                player.Damage = player.BASE_DAMAGE + player.Level;
                lbClass.Text = typeof(Mage).Name;
            }
        }

        private void GainExperience()
        {
            player.CurrentXP += monster.Experience;
            
            txtProgress.AppendText("Gained " + monster.Experience + " xp.\r\n");
            if (player.CurrentXP >= player.MaxXP)
            {
                int exceed = player.CurrentXP - player.MaxXP;
                player.MaxXP = Convert.ToInt32(player.MaxXP * 1.5);
                player.CurrentXP = exceed;
                player.Level += 1;
                player.MaxHP += player.BASE_HP;
                player.CurrentHP = player.MaxHP;
                player.Damage = player.BASE_DAMAGE + player.Level;

                HPBarP.Maximum = player.MaxHP;
                HPBarP.Value = player.CurrentHP;               
                lbPlayerHP.Text = HPBarP.Value + "/" + HPBarP.Maximum;
                lbLVP.Text = player.Level.ToString();
                lbDMG.Text = player.Damage.ToString() + " - " + (player.Damage + (player.Level + 1));

                txtProgress.AppendText("You leveled up!\r\n");
                if (player.Level % 2 == 0) cbItems.Items.Add("Healing Potion");
                if (player.Level % 3 == 0) bossActivated = true;
                if (player.Level % 10 == 0) nemesisActivated = true;
                if (player.Level == 5)
                {
                    ChangeClasses();
                    HPBarP.Maximum = player.MaxHP;
                    HPBarP.Value = player.CurrentHP;
                    lbPlayerHP.Text = HPBarP.Value + "/" + HPBarP.Maximum;
                }
            }
            txtProgress.AppendText("--------------------------------------------\r\n");
            lbExp.Text = player.CurrentXP + "/" + player.MaxXP;
            //
            if (isAutoClear) txtProgress.Clear();
        }

        private int CalculateDamage()
        {
            int PLAYER_DAM_DICE = rand.Next(player.Level + 1);
            int damage = player.Damage + PLAYER_DAM_DICE;
            return damage;
        }

        private int KnightReduceDamage(int damage)
        {
            int chance = rand.Next(0, 100);
            if (chance <= 25)
            {
                damage /= 2;
                txtProgress.AppendText("Bulwark activated!\r\n");
            }
            return damage;
        }

        private void FighterAftermath()
        {
            int PERCENT = 8;
            int restoredHP = Convert.ToInt32(player.MaxHP * PERCENT / 100);
            player.CurrentHP += restoredHP;
            if (player.CurrentHP >= player.MaxHP)
                player.CurrentHP = player.MaxHP;
            HPBarP.Value = player.CurrentHP;
            UpdateHPLabel(true);
        }

        private int FighterBrawlIncreaseDamage(int damage, ref string bonusText)
        {
            int PERCENT = 10;
            int increase =  Math.Abs(Convert.ToInt32(monster.CurrentHP * PERCENT / 100));
            damage += increase;
            bonusText = "(+" + Math.Abs(increase) + ")";
            return damage;
        }

        private int NukeDamage(int damage)
        {
            int chance = rand.Next(0, 100);
            if (chance <= 15)
            {
                damage *= 3;
                txtProgress.AppendText("NUKE!\r\n");
            }
            return damage;
        }
        private void btnAtk_Click(object sender, EventArgs e)
        {
            if (player.CurrentHP > 0 && monster.CurrentHP > 0)
            {
                string brawlBonusText = "";
                int damage = CalculateDamage();
                if (player.GetType().Equals(typeof(MainChar.Fighter)))
                {
                    damage = FighterBrawlIncreaseDamage(damage, ref brawlBonusText);
                }
                else if (player.GetType().Equals(typeof(Mage))){
                    damage = NukeDamage(damage);
                }
                monster.CurrentHP -= damage;
                UpdateHPBar(false, damage);
                txtProgress.AppendText("You did " + damage + brawlBonusText + " damage!\r\n");
                if (monster.CurrentHP <= 0)
                {
                    CheckActivated();
                    txtProgress.AppendText(monster.Name + " dead...\r\n");
                    GainExperience();
                    if (player.GetType().Equals(typeof(MainChar.Fighter)))
                        FighterAftermath();
                    if (nemesisActivated)
                    {
                        monster = MonsterGenerator.GenerateNemesis(player);
                        //nemesisActivated = false;
                    }
                    else if (bossActivated)
                    {
                        monster = MonsterGenerator.GenerateBoss(player);
                       // bossActivated = false;
                    }
                    else
                        monster = MonsterGenerator.GenerateMonster(player);
                    UpdateNewMonster();
                }
                else
                {
                    int MONSTER_DAM_DICE = rand.Next(monster.Level);
                    damage = monster.Damage + MONSTER_DAM_DICE;
                    if (player.GetType().Equals(typeof(Knight)))
                        damage = KnightReduceDamage(damage);
                    player.CurrentHP -= damage;
                    UpdateHPBar(true, damage);
                    txtProgress.AppendText(monster.Name + " did " + damage + " damage...\r\n");
                    if (player.CurrentHP <= 0)
                    {
                        MessageBox.Show("You dissipated! What a shame!");
                        //this.Dispose();
                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                        this.Close();
                    }
                }          
            }
            
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtProgress.Clear();
        }

        private void CalculateCounterDef()
        {
            int MONSTER_DAM_COUNTER = Convert.ToInt32(monster.Damage * 50 / 100);
            int PERCENT = Math.Abs(Convert.ToInt32(player.CurrentHP * 10 / 100));
            int damage = PERCENT + MONSTER_DAM_COUNTER;
            monster.CurrentHP -= damage;
            UpdateHPBar(false, damage);
            txtProgress.AppendText("You countered " + damage + " damage!\r\n");
            if (monster.CurrentHP <= 0)
            {
                CheckActivated();
                txtProgress.AppendText(monster.Name + " dead...\r\n");
                GainExperience();
                if (nemesisActivated)
                {
                    monster = MonsterGenerator.GenerateNemesis(player);
                    //nemesisActivated = false;
                }
                else
                if (bossActivated)
                {
                    monster = MonsterGenerator.GenerateBoss(player);
                    //bossActivated = false;
                }
                else
                    monster = MonsterGenerator.GenerateMonster(player);
                UpdateNewMonster();
            }
        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            if (player.CurrentHP > 0 && monster.CurrentHP > 0)
            {
                txtProgress.AppendText("You defend an attack...\r\n");
                int MONSTER_DAM_DICE = rand.Next(monster.Level);
                int damage = 0;
                if (player.GetType().Equals(typeof(Knight)))
                {
                    damage = Convert.ToInt32((monster.Damage + MONSTER_DAM_DICE) / 3);
                }
                else damage = Convert.ToInt32((monster.Damage + MONSTER_DAM_DICE) / 2);
                player.CurrentHP -= damage;
                UpdateHPBar(true, damage);
                txtProgress.AppendText(monster.Name + " did only " + damage + " damage!\r\n");
                if (player.CurrentHP <= 0)
                {
                    MessageBox.Show("You dissipated! What a shame!");
                    //this.Dispose();
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (player.GetType().Equals(typeof(Knight)))
                {
                    CalculateCounterDef();
                }
            }
        }
        private int CalculateStrongDamage(ref string text)
        {
            int randomRoll = rand.Next(0, 100);
            int PLAYER_DAM_DICE = 0;
            if (randomRoll > 50)
            {
                PLAYER_DAM_DICE = -(player.Damage / 2);
                text = "You did a heavy attack, but it missed! ";
            }
            else
            {
                PLAYER_DAM_DICE = player.Damage;
                text = "Lucky Shotttt! ";
            }
            int damage = player.Damage + PLAYER_DAM_DICE;
            return damage;
        }

        private int MageBurstOption(ref string text)
        {
            int randomRoll = rand.Next(0, 100);
            int PLAYER_DAM_DICE = 0;
            if (randomRoll > 65)
            {
                PLAYER_DAM_DICE = -(player.Damage / 2);
                text = "You did a heavy attack, but it missed! ";
            }
            else
            {
                PLAYER_DAM_DICE = player.Damage * 3;
                text = "Burst Option Activated! ";
            }
            int damage = player.Damage + PLAYER_DAM_DICE;
            return damage;
        }

        private void btnStrAtk_Click(object sender, EventArgs e)
        {
            if (player.CurrentHP > 0 && monster.CurrentHP > 0)
            {
                string brawlBonusText = "";
                string text = "";
                int damage = 0;
                if (player.GetType().Equals(typeof(Mage)))
                {
                    damage = MageBurstOption(ref text);
                    damage = NukeDamage(damage);
                }
                else damage = CalculateStrongDamage(ref text);
                if (player.GetType().Equals(typeof(MainChar.Fighter)))
                    damage = FighterBrawlIncreaseDamage(damage, ref brawlBonusText);
                monster.CurrentHP -= damage;
                UpdateHPBar(false, damage);
                txtProgress.AppendText(text + "You did " + damage + brawlBonusText + " damage!\r\n");
                if (monster.CurrentHP <= 0)
                {
                    CheckActivated();
                    txtProgress.AppendText(monster.Name + " dead...\r\n");
                    GainExperience();
                    if (player.GetType().Equals(typeof(MainChar.Fighter)))
                        FighterAftermath();
                    if (nemesisActivated)
                    {
                        monster = MonsterGenerator.GenerateNemesis(player);
                        //nemesisActivated = false;
                    }
                    else
                    if (bossActivated)
                    {
                        monster = MonsterGenerator.GenerateBoss(player);
                        //bossActivated = false;
                    }
                    else monster = MonsterGenerator.GenerateMonster(player);
                    UpdateNewMonster();
                }
                else
                {
                    int MONSTER_DAM_DICE = rand.Next(monster.Level);
                    damage = monster.Damage + MONSTER_DAM_DICE;
                    if (player.GetType().Equals(typeof(Knight)))
                        damage = KnightReduceDamage(damage);
                    player.CurrentHP -= damage;
                    UpdateHPBar(true, damage);
                    txtProgress.AppendText(monster.Name + " did " + damage + " damage...\r\n");
                    if (player.CurrentHP <= 0)
                    {
                        MessageBox.Show("You dissipated! What a shame!");
                        //this.Dispose();
                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                        this.Close();
                    }
                }
            }
        }

        private void btnFlee_Click(object sender, EventArgs e)
        {
            if (bossActivated == true || nemesisActivated == true)
            {
                txtProgress.AppendText("You cannot outrun this boss monster!!\r\n");              
            }
            else
            {
                txtProgress.AppendText("You fleed from the monster...\r\n");
                int penalty = player.CurrentHP > 1 ? player.CurrentHP / 2 : 0;
                player.CurrentHP -= penalty;
                UpdateHPBar(true, penalty);
                monster = MonsterGenerator.GenerateMonster(player);
                UpdateNewMonster();
            }
            

        }

        private void UsingHPPotion()
        {
            int heal = player.MaxHP / 2;
            player.CurrentHP = (player.CurrentHP + heal > player.MaxHP) ? player.MaxHP : player.CurrentHP + heal;
            UpdateHPBarHealing(true, heal);
        }

        private void btnUseItem_Click(object sender, EventArgs e)
        {
            string item = cbItems.SelectedItem == null ? "" : cbItems.SelectedItem.ToString();
            switch (item)
            {
                #region HP Potion
                case "Healing Potion":
                    if (player.CurrentHP == player.MaxHP)
                    {
                        DialogResult res = MessageBox.Show(this, "You are going to use a potion when full health! Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            txtProgress.AppendText("You use a Healing Potion.\r\n");
                            UsingHPPotion();
                            cbItems.Items.Remove(item);
                        }
                    }
                    else
                    {
                        txtProgress.AppendText("You use a Healing Potion.\r\n");
                        UsingHPPotion();
                        cbItems.Items.Remove(item);
                    }
                    break;
                #endregion
                default:
                    break;
            }
        }

        private void chkAutoClear_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoClear.Checked) isAutoClear = true;
            else isAutoClear = false;
        }
    }
}
