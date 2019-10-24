using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighter
{
    public partial class ChangeClassForm : Form
    {
        enum Classes
        {
            Knight, Fighter, Mage
        }

        string[] type = new string[3];
        string[] traits = new string[3];
        string[] specbility = new string[3];
        public ChangeClassForm()
        {
            InitializeComponent();
        }

        private void ChangeClassForm_Load(object sender, EventArgs e)
        {
            init();   
        }

        private void init()
        {
            type[(int)Classes.Knight] = "Tank";
            type[(int)Classes.Fighter] = "Bruiser";
            type[(int)Classes.Mage] = "Glass Cannon";

            traits[(int)Classes.Knight] = "High HP, survivability but cripple from low Damage";
            traits[(int)Classes.Fighter] = "Moderate HP and Damage, able to self-sustained for a long time";
            traits[(int)Classes.Mage] = "High Damage but suffer from low HP, need much caution";

            specbility[(int)Classes.Knight] = "• Counter Defend: Further reduce the damage received and counter back based on your current HP.\r\n• Bulwark: 25 % chance to receive only half of damage when attacked (not include when defending).";
            specbility[(int)Classes.Fighter] = "• Aftermath: Restore %HP after every won fight.\r\n• Brawl: Deal bonus damage base on monster current HP.";
            specbility[(int)Classes.Mage] = "• Nuke: 15% chance to deal 3x damage.\r\n• Burst Option: Strong attack deals 4x damage instead and has higher chance to land an attack.";
        }

        private void rbKnight_CheckedChanged(object sender, EventArgs e)
        {
            lbType.Text = type[(int)Classes.Knight];
            lbTraits.Text = traits[(int)Classes.Knight];
            txtAbilities.Text = specbility[(int)Classes.Knight];
        }

        private void rbFighter_CheckedChanged(object sender, EventArgs e)
        {
            lbType.Text = type[(int)Classes.Fighter];
            lbTraits.Text = traits[(int)Classes.Fighter];
            txtAbilities.Text = specbility[(int)Classes.Fighter];
        }

        private void rbMage_CheckedChanged(object sender, EventArgs e)
        {
            lbType.Text = type[(int)Classes.Mage];
            lbTraits.Text = traits[(int)Classes.Mage];
            txtAbilities.Text = specbility[(int)Classes.Mage];
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (rbKnight.Checked) DialogResult = DialogResult.OK;
            if (rbFighter.Checked) DialogResult = DialogResult.Cancel;
            if (rbMage.Checked) DialogResult = DialogResult.Yes;
        }
    }
}
