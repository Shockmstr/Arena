namespace Fighter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDef = new System.Windows.Forms.Button();
            this.btnStrAtk = new System.Windows.Forms.Button();
            this.btnAtk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HPBarM = new System.Windows.Forms.ProgressBar();
            this.HPBarP = new System.Windows.Forms.ProgressBar();
            this.lbPlayerHP = new System.Windows.Forms.Label();
            this.lbMonsterHP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLVP = new System.Windows.Forms.Label();
            this.lbLVM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbExp = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lbClass = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lbDMG = new System.Windows.Forms.Label();
            this.btnFlee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProgress
            // 
            this.txtProgress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgress.Location = new System.Drawing.Point(450, 70);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProgress.Size = new System.Drawing.Size(323, 372);
            this.txtProgress.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFlee);
            this.groupBox1.Controls.Add(this.btnDef);
            this.groupBox1.Controls.Add(this.btnStrAtk);
            this.groupBox1.Controls.Add(this.btnAtk);
            this.groupBox1.Location = new System.Drawing.Point(92, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btnDef
            // 
            this.btnDef.Location = new System.Drawing.Point(187, 28);
            this.btnDef.Name = "btnDef";
            this.btnDef.Size = new System.Drawing.Size(75, 34);
            this.btnDef.TabIndex = 2;
            this.btnDef.Text = "Defend";
            this.toolTip.SetToolTip(this.btnDef, "Reduce an incoming attack of enemy by half.\r\nReduce more when you\'re Knight");
            this.btnDef.UseVisualStyleBackColor = true;
            this.btnDef.Click += new System.EventHandler(this.btnDef_Click);
            // 
            // btnStrAtk
            // 
            this.btnStrAtk.Location = new System.Drawing.Point(35, 84);
            this.btnStrAtk.Name = "btnStrAtk";
            this.btnStrAtk.Size = new System.Drawing.Size(75, 40);
            this.btnStrAtk.TabIndex = 1;
            this.btnStrAtk.Text = "Strong Attack";
            this.toolTip.SetToolTip(this.btnStrAtk, "Use all your strength to attack. 50% chance to deals 2x damage or miss by half da" +
        "mage.\r\nTurn into Burst Option when you\'re Mage.");
            this.btnStrAtk.UseVisualStyleBackColor = true;
            this.btnStrAtk.Click += new System.EventHandler(this.btnStrAtk_Click);
            // 
            // btnAtk
            // 
            this.btnAtk.Location = new System.Drawing.Point(35, 28);
            this.btnAtk.Name = "btnAtk";
            this.btnAtk.Size = new System.Drawing.Size(75, 34);
            this.btnAtk.TabIndex = 0;
            this.btnAtk.Text = "Attack";
            this.toolTip.SetToolTip(this.btnAtk, "Attack your enemy equals to your damage");
            this.btnAtk.UseVisualStyleBackColor = true;
            this.btnAtk.Click += new System.EventHandler(this.btnAtk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(815, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(892, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // HPBarM
            // 
            this.HPBarM.Location = new System.Drawing.Point(818, 92);
            this.HPBarM.Name = "HPBarM";
            this.HPBarM.Size = new System.Drawing.Size(302, 35);
            this.HPBarM.TabIndex = 2;
            // 
            // HPBarP
            // 
            this.HPBarP.Location = new System.Drawing.Point(92, 94);
            this.HPBarP.Name = "HPBarP";
            this.HPBarP.Size = new System.Drawing.Size(302, 33);
            this.HPBarP.TabIndex = 1;
            // 
            // lbPlayerHP
            // 
            this.lbPlayerHP.AutoSize = true;
            this.lbPlayerHP.BackColor = System.Drawing.Color.LimeGreen;
            this.lbPlayerHP.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerHP.Location = new System.Drawing.Point(211, 103);
            this.lbPlayerHP.Name = "lbPlayerHP";
            this.lbPlayerHP.Size = new System.Drawing.Size(45, 15);
            this.lbPlayerHP.TabIndex = 7;
            this.lbPlayerHP.Text = "label4";
            // 
            // lbMonsterHP
            // 
            this.lbMonsterHP.AutoSize = true;
            this.lbMonsterHP.BackColor = System.Drawing.Color.LimeGreen;
            this.lbMonsterHP.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonsterHP.Location = new System.Drawing.Point(943, 103);
            this.lbMonsterHP.Name = "lbMonsterHP";
            this.lbMonsterHP.Size = new System.Drawing.Size(45, 15);
            this.lbMonsterHP.TabIndex = 8;
            this.lbMonsterHP.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Level:";
            // 
            // lbLVP
            // 
            this.lbLVP.AutoSize = true;
            this.lbLVP.Location = new System.Drawing.Point(124, 141);
            this.lbLVP.Name = "lbLVP";
            this.lbLVP.Size = new System.Drawing.Size(35, 13);
            this.lbLVP.TabIndex = 11;
            this.lbLVP.Text = "label6";
            // 
            // lbLVM
            // 
            this.lbLVM.AutoSize = true;
            this.lbLVM.Location = new System.Drawing.Point(857, 175);
            this.lbLVM.Name = "lbLVM";
            this.lbLVM.Size = new System.Drawing.Size(35, 13);
            this.lbLVM.TabIndex = 12;
            this.lbLVM.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Exp:";
            // 
            // lbExp
            // 
            this.lbExp.AutoSize = true;
            this.lbExp.Location = new System.Drawing.Point(282, 141);
            this.lbExp.Name = "lbExp";
            this.lbExp.Size = new System.Drawing.Size(35, 13);
            this.lbExp.TabIndex = 14;
            this.lbExp.Text = "label7";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(450, 460);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 15;
            this.btnClearLog.Text = "Clear Log";
            this.toolTip.SetToolTip(this.btnClearLog, "Clears all text entry");
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(86, 28);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(87, 31);
            this.lbClass.TabIndex = 16;
            this.lbClass.Text = "label7";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 20000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Damage:";
            // 
            // lbDMG
            // 
            this.lbDMG.AutoSize = true;
            this.lbDMG.Location = new System.Drawing.Point(138, 175);
            this.lbDMG.Name = "lbDMG";
            this.lbDMG.Size = new System.Drawing.Size(35, 13);
            this.lbDMG.TabIndex = 18;
            this.lbDMG.Text = "label8";
            // 
            // btnFlee
            // 
            this.btnFlee.Location = new System.Drawing.Point(187, 84);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(75, 40);
            this.btnFlee.TabIndex = 3;
            this.btnFlee.Text = "Flee";
            this.toolTip.SetToolTip(this.btnFlee, "Flee the battle but losing half of your current HP.");
            this.btnFlee.UseVisualStyleBackColor = true;
            this.btnFlee.Click += new System.EventHandler(this.btnFlee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 610);
            this.Controls.Add(this.lbDMG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.lbExp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbLVM);
            this.Controls.Add(this.lbLVP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMonsterHP);
            this.Controls.Add(this.lbPlayerHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HPBarM);
            this.Controls.Add(this.HPBarP);
            this.Controls.Add(this.txtProgress);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDef;
        private System.Windows.Forms.Button btnStrAtk;
        private System.Windows.Forms.Button btnAtk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar HPBarM;
        private System.Windows.Forms.ProgressBar HPBarP;
        private System.Windows.Forms.Label lbPlayerHP;
        private System.Windows.Forms.Label lbMonsterHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLVP;
        private System.Windows.Forms.Label lbLVM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbExp;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDMG;
        private System.Windows.Forms.Button btnFlee;
    }
}

