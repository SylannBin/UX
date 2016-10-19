namespace UX
{
    partial class PlaylistPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistPanel));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_currentMenu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_main = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Recherche";
            // 
            // button_currentMenu
            // 
            this.button_currentMenu.Location = new System.Drawing.Point(50, 1);
            this.button_currentMenu.Name = "button_currentMenu";
            this.button_currentMenu.Size = new System.Drawing.Size(333, 44);
            this.button_currentMenu.TabIndex = 13;
            this.button_currentMenu.Text = "Playlists";
            this.button_currentMenu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(29, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Playlist 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "25 morceaux";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Durée : 40 min";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(38, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 76);
            this.panel5.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_menu);
            this.panel1.Location = new System.Drawing.Point(1, 204);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(381, 455);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = global::UX.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(165, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_main
            // 
            this.button_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_main.BackgroundImage")));
            this.button_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_main.Image = ((System.Drawing.Image)(resources.GetObject("button_main.Image")));
            this.button_main.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_main.Location = new System.Drawing.Point(1, 1);
            this.button_main.MaximumSize = new System.Drawing.Size(76, 45);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(49, 44);
            this.button_main.TabIndex = 12;
            this.button_main.UseVisualStyleBackColor = true;
            // 
            // button_menu
            // 
            this.button_menu.Location = new System.Drawing.Point(-1, 391);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(65, 65);
            this.button_menu.TabIndex = 17;
            this.button_menu.Text = "Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel2.Location = new System.Drawing.Point(105, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 153);
            this.panel2.TabIndex = 19;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(55, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Validé";
            this.label11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label11_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(3, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Calm                       Sad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Epic                       Nice";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(66, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 35);
            this.panel3.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Durée",
            "Nombre"});
            this.comboBox1.Location = new System.Drawing.Point(5, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Choisissez";
            this.comboBox1.UseWaitCursor = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Générer une playlist";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "10";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.Location = new System.Drawing.Point(143, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 54);
            this.button2.TabIndex = 21;
            this.button2.Text = "Générer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Durée/nombre musiques";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Méthode de génération";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Location = new System.Drawing.Point(69, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 35);
            this.panel4.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Aléatoire",
            "Non écoutées",
            "Préférées",
            "Magie"});
            this.comboBox2.Location = new System.Drawing.Point(5, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(230, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Choisissez";
            this.comboBox2.UseWaitCursor = true;
            // 
            // PlaylistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_currentMenu);
            this.Controls.Add(this.button_main);
            this.Name = "PlaylistPanel";
            this.Text = "PlaylistPanel";
            this.Load += new System.EventHandler(this.PlaylistPanel_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_currentMenu;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}