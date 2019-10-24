namespace Fighter
{
    partial class ChangeClassForm
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
            this.rbKnight = new System.Windows.Forms.RadioButton();
            this.rbFighter = new System.Windows.Forms.RadioButton();
            this.rbMage = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAbilities = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbTraits = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbKnight
            // 
            this.rbKnight.AutoSize = true;
            this.rbKnight.Location = new System.Drawing.Point(22, 29);
            this.rbKnight.Name = "rbKnight";
            this.rbKnight.Size = new System.Drawing.Size(55, 17);
            this.rbKnight.TabIndex = 0;
            this.rbKnight.TabStop = true;
            this.rbKnight.Text = "Knight";
            this.rbKnight.UseVisualStyleBackColor = true;
            this.rbKnight.CheckedChanged += new System.EventHandler(this.rbKnight_CheckedChanged);
            // 
            // rbFighter
            // 
            this.rbFighter.AutoSize = true;
            this.rbFighter.Location = new System.Drawing.Point(171, 29);
            this.rbFighter.Name = "rbFighter";
            this.rbFighter.Size = new System.Drawing.Size(57, 17);
            this.rbFighter.TabIndex = 1;
            this.rbFighter.TabStop = true;
            this.rbFighter.Text = "Fighter";
            this.rbFighter.UseVisualStyleBackColor = true;
            this.rbFighter.CheckedChanged += new System.EventHandler(this.rbFighter_CheckedChanged);
            // 
            // rbMage
            // 
            this.rbMage.AutoSize = true;
            this.rbMage.Location = new System.Drawing.Point(323, 29);
            this.rbMage.Name = "rbMage";
            this.rbMage.Size = new System.Drawing.Size(52, 17);
            this.rbMage.TabIndex = 2;
            this.rbMage.TabStop = true;
            this.rbMage.Text = "Mage";
            this.rbMage.UseVisualStyleBackColor = true;
            this.rbMage.CheckedChanged += new System.EventHandler(this.rbMage_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKnight);
            this.groupBox1.Controls.Add(this.rbMage);
            this.groupBox1.Controls.Add(this.rbFighter);
            this.groupBox1.Location = new System.Drawing.Point(56, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Classes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTraits);
            this.groupBox2.Controls.Add(this.lbType);
            this.groupBox2.Controls.Add(this.txtAbilities);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(23, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 237);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "• Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "• Traits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "• Special Abilities:";
            // 
            // txtAbilities
            // 
            this.txtAbilities.Location = new System.Drawing.Point(33, 119);
            this.txtAbilities.Multiline = true;
            this.txtAbilities.Name = "txtAbilities";
            this.txtAbilities.Size = new System.Drawing.Size(446, 112);
            this.txtAbilities.TabIndex = 3;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(79, 34);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(35, 13);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "label4";
            // 
            // lbTraits
            // 
            this.lbTraits.AutoSize = true;
            this.lbTraits.Location = new System.Drawing.Point(81, 68);
            this.lbTraits.Name = "lbTraits";
            this.lbTraits.Size = new System.Drawing.Size(35, 13);
            this.lbTraits.TabIndex = 5;
            this.lbTraits.Text = "label5";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(206, 390);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(114, 23);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Choose this class";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // ChangeClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 425);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangeClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Class";
            this.Load += new System.EventHandler(this.ChangeClassForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKnight;
        private System.Windows.Forms.RadioButton rbFighter;
        private System.Windows.Forms.RadioButton rbMage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTraits;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox txtAbilities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoose;
    }
}