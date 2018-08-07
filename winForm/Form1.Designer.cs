namespace winForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSpellBook = new System.Windows.Forms.Button();
            this.buttonInv = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCommand = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblPlayerXP = new System.Windows.Forms.Label();
            this.lblPlayerLVL = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonSpellBook);
            this.panel1.Controls.Add(this.buttonInv);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 550);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHelp.Location = new System.Drawing.Point(0, 425);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(193, 91);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Stats";
            this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSpellBook
            // 
            this.buttonSpellBook.FlatAppearance.BorderSize = 0;
            this.buttonSpellBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpellBook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpellBook.ForeColor = System.Drawing.Color.White;
            this.buttonSpellBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpellBook.Image")));
            this.buttonSpellBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSpellBook.Location = new System.Drawing.Point(0, 328);
            this.buttonSpellBook.Name = "buttonSpellBook";
            this.buttonSpellBook.Size = new System.Drawing.Size(193, 91);
            this.buttonSpellBook.TabIndex = 3;
            this.buttonSpellBook.Text = "Spellbook";
            this.buttonSpellBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSpellBook.UseVisualStyleBackColor = true;
            this.buttonSpellBook.Click += new System.EventHandler(this.buttonSpellBook_Click);
            // 
            // buttonInv
            // 
            this.buttonInv.FlatAppearance.BorderSize = 0;
            this.buttonInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInv.ForeColor = System.Drawing.Color.White;
            this.buttonInv.Image = ((System.Drawing.Image)(resources.GetObject("buttonInv.Image")));
            this.buttonInv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonInv.Location = new System.Drawing.Point(0, 231);
            this.buttonInv.Name = "buttonInv";
            this.buttonInv.Size = new System.Drawing.Size(193, 91);
            this.buttonInv.TabIndex = 3;
            this.buttonInv.Text = "Inventory";
            this.buttonInv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInv.UseVisualStyleBackColor = true;
            this.buttonInv.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHome.Location = new System.Drawing.Point(0, 134);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(193, 91);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 90);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, -16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 117);
            this.label2.TabIndex = 3;
            this.label2.Text = "m";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnCommand);
            this.panel2.Controls.Add(this.txtCommand);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(193, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 145);
            this.panel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(706, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 48);
            this.button6.TabIndex = 2;
            this.button6.Text = "button2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(571, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 49);
            this.button5.TabIndex = 2;
            this.button5.Text = "button2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(436, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 48);
            this.button4.TabIndex = 2;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(305, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(177, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // btnCommand
            // 
            this.btnCommand.FlatAppearance.BorderSize = 0;
            this.btnCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommand.Location = new System.Drawing.Point(64, 55);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(91, 51);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "Confirm";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(23, 21);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(191, 27);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "Select a name";
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Location = new System.Drawing.Point(474, 36);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(107, 21);
            this.lblPlayerHP.TabIndex = 2;
            this.lblPlayerHP.Text = "Playerhealth";
            this.lblPlayerHP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayerXP
            // 
            this.lblPlayerXP.AutoSize = true;
            this.lblPlayerXP.Location = new System.Drawing.Point(619, 36);
            this.lblPlayerXP.Name = "lblPlayerXP";
            this.lblPlayerXP.Size = new System.Drawing.Size(76, 21);
            this.lblPlayerXP.TabIndex = 2;
            this.lblPlayerXP.Text = "playerXP";
            this.lblPlayerXP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayerLVL
            // 
            this.lblPlayerLVL.AutoSize = true;
            this.lblPlayerLVL.Location = new System.Drawing.Point(733, 36);
            this.lblPlayerLVL.Name = "lblPlayerLVL";
            this.lblPlayerLVL.Size = new System.Drawing.Size(83, 21);
            this.lblPlayerLVL.TabIndex = 2;
            this.lblPlayerLVL.Text = "playerLVL";
            this.lblPlayerLVL.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(193, 134);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(7, 72);
            this.panelLeft.TabIndex = 3;
            // 
            // txtOne
            // 
            this.txtOne.BackColor = System.Drawing.Color.Black;
            this.txtOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOne.ForeColor = System.Drawing.Color.White;
            this.txtOne.Location = new System.Drawing.Point(257, 134);
            this.txtOne.Multiline = true;
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(740, 220);
            this.txtOne.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(962, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(334, 36);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(102, 21);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Playername";
            this.lblPlayerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFour
            // 
            this.txtFour.BackColor = System.Drawing.Color.Black;
            this.txtFour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFour.ForeColor = System.Drawing.Color.White;
            this.txtFour.Location = new System.Drawing.Point(257, 134);
            this.txtFour.Multiline = true;
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(740, 220);
            this.txtFour.TabIndex = 4;
            // 
            // txtThree
            // 
            this.txtThree.BackColor = System.Drawing.Color.Black;
            this.txtThree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThree.ForeColor = System.Drawing.Color.White;
            this.txtThree.Location = new System.Drawing.Point(257, 134);
            this.txtThree.Multiline = true;
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(740, 220);
            this.txtThree.TabIndex = 4;
            // 
            // txtTwo
            // 
            this.txtTwo.BackColor = System.Drawing.Color.Black;
            this.txtTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTwo.ForeColor = System.Drawing.Color.White;
            this.txtTwo.Location = new System.Drawing.Point(257, 134);
            this.txtTwo.Multiline = true;
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(740, 220);
            this.txtTwo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1056, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.lblPlayerLVL);
            this.Controls.Add(this.lblPlayerXP);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFour);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSpellBook;
        private System.Windows.Forms.Button buttonInv;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblPlayerXP;
        private System.Windows.Forms.Label lblPlayerLVL;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.TextBox txtTwo;
    }
}

