namespace UX
{
    partial class Simplified
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simplified));
            this.button_showMenu = new System.Windows.Forms.Button();
            this.button_currentMenu = new System.Windows.Forms.Button();
            this.button_main = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_addPlaylist = new System.Windows.Forms.Label();
            this.bt_sim_openPlaylist = new System.Windows.Forms.Button();
            this.label_addToFav = new System.Windows.Forms.Label();
            this.bt_sim_addPlaylist = new System.Windows.Forms.Button();
            this.bt_sim_addToFav = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.PictureBox();
            this.bt_sim_stopStart = new System.Windows.Forms.Button();
            this.bt_sim_swipeRight = new System.Windows.Forms.Button();
            this.bt_sim_swipeLeft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_showMenu
            // 
            this.button_showMenu.Location = new System.Drawing.Point(1, 595);
            this.button_showMenu.Name = "button_showMenu";
            this.button_showMenu.Size = new System.Drawing.Size(65, 65);
            this.button_showMenu.TabIndex = 23;
            this.button_showMenu.Text = "Mode Normal";
            this.button_showMenu.UseVisualStyleBackColor = true;
            this.button_showMenu.Click += new System.EventHandler(this.button_showMenu_Sim_Click);
            // 
            // button_currentMenu
            // 
            this.button_currentMenu.Location = new System.Drawing.Point(50, -1);
            this.button_currentMenu.Name = "button_currentMenu";
            this.button_currentMenu.Size = new System.Drawing.Size(333, 44);
            this.button_currentMenu.TabIndex = 22;
            this.button_currentMenu.Text = "Mode Simplifié";
            this.button_currentMenu.UseVisualStyleBackColor = true;
            this.button_currentMenu.Click += new System.EventHandler(this.button_currentMenu_Sim_Click);
            // 
            // button_main
            // 
            this.button_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_main.BackgroundImage")));
            this.button_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_main.Image = ((System.Drawing.Image)(resources.GetObject("button_main.Image")));
            this.button_main.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_main.Location = new System.Drawing.Point(1, -1);
            this.button_main.MaximumSize = new System.Drawing.Size(76, 45);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(49, 44);
            this.button_main.TabIndex = 21;
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.button_main_Sim_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UX.Properties.Resources.witcher3Cover;
            this.panel1.Controls.Add(this.label_addPlaylist);
            this.panel1.Controls.Add(this.bt_sim_openPlaylist);
            this.panel1.Controls.Add(this.label_addToFav);
            this.panel1.Controls.Add(this.bt_sim_addPlaylist);
            this.panel1.Controls.Add(this.bt_sim_addToFav);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.bt_sim_stopStart);
            this.panel1.Controls.Add(this.bt_sim_swipeRight);
            this.panel1.Controls.Add(this.bt_sim_swipeLeft);
            this.panel1.Location = new System.Drawing.Point(2, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 610);
            this.panel1.TabIndex = 20;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label_addPlaylist
            // 
            this.label_addPlaylist.AutoSize = true;
            this.label_addPlaylist.Location = new System.Drawing.Point(213, 531);
            this.label_addPlaylist.Name = "label_addPlaylist";
            this.label_addPlaylist.Size = new System.Drawing.Size(153, 13);
            this.label_addPlaylist.TabIndex = 27;
            this.label_addPlaylist.Text = "Playlist créée, Musique ajoutée";
            this.label_addPlaylist.Visible = false;
            this.label_addPlaylist.Click += new System.EventHandler(this.label_addPlaylist_Click);
            // 
            // bt_sim_openPlaylist
            // 
            this.bt_sim_openPlaylist.BackgroundImage = global::UX.Properties.Resources.playlist2;
            this.bt_sim_openPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sim_openPlaylist.Location = new System.Drawing.Point(145, 553);
            this.bt_sim_openPlaylist.Name = "bt_sim_openPlaylist";
            this.bt_sim_openPlaylist.Size = new System.Drawing.Size(45, 45);
            this.bt_sim_openPlaylist.TabIndex = 26;
            this.bt_sim_openPlaylist.UseVisualStyleBackColor = true;
            this.bt_sim_openPlaylist.Click += new System.EventHandler(this.bt_sim_openPlaylist_Click);
            // 
            // label_addToFav
            // 
            this.label_addToFav.AutoSize = true;
            this.label_addToFav.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_addToFav.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_addToFav.Location = new System.Drawing.Point(276, 518);
            this.label_addToFav.Name = "label_addToFav";
            this.label_addToFav.Size = new System.Drawing.Size(91, 13);
            this.label_addToFav.TabIndex = 25;
            this.label_addToFav.Text = "Ajouté aux favoris";
            this.label_addToFav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_addToFav.Visible = false;
            this.label_addToFav.Click += new System.EventHandler(this.label_addToFav_Click);
            // 
            // bt_sim_addPlaylist
            // 
            this.bt_sim_addPlaylist.BackgroundImage = global::UX.Properties.Resources.playlist;
            this.bt_sim_addPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sim_addPlaylist.Location = new System.Drawing.Point(210, 554);
            this.bt_sim_addPlaylist.Name = "bt_sim_addPlaylist";
            this.bt_sim_addPlaylist.Size = new System.Drawing.Size(45, 45);
            this.bt_sim_addPlaylist.TabIndex = 24;
            this.bt_sim_addPlaylist.UseVisualStyleBackColor = true;
            this.bt_sim_addPlaylist.Click += new System.EventHandler(this.bt_sim_addPlaylist_Click);
            // 
            // bt_sim_addToFav
            // 
            this.bt_sim_addToFav.BackColor = System.Drawing.Color.Transparent;
            this.bt_sim_addToFav.BackgroundImage = global::UX.Properties.Resources.love1;
            this.bt_sim_addToFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sim_addToFav.Location = new System.Drawing.Point(272, 553);
            this.bt_sim_addToFav.Name = "bt_sim_addToFav";
            this.bt_sim_addToFav.Size = new System.Drawing.Size(45, 45);
            this.bt_sim_addToFav.TabIndex = 23;
            this.bt_sim_addToFav.UseVisualStyleBackColor = false;
            this.bt_sim_addToFav.Click += new System.EventHandler(this.bt_sim_addToFav_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackgroundImage = global::UX.Properties.Resources.sndcldBIG;
            this.progressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.progressBar1.InitialImage = null;
            this.progressBar1.Location = new System.Drawing.Point(34, 301);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(548, 157);
            this.progressBar1.TabIndex = 22;
            this.progressBar1.TabStop = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // bt_sim_stopStart
            // 
            this.bt_sim_stopStart.BackgroundImage = global::UX.Properties.Resources.tiny_play;
            this.bt_sim_stopStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_sim_stopStart.Location = new System.Drawing.Point(172, 255);
            this.bt_sim_stopStart.Name = "bt_sim_stopStart";
            this.bt_sim_stopStart.Size = new System.Drawing.Size(40, 40);
            this.bt_sim_stopStart.TabIndex = 21;
            this.bt_sim_stopStart.UseVisualStyleBackColor = true;
            this.bt_sim_stopStart.Visible = false;
            this.bt_sim_stopStart.Click += new System.EventHandler(this.bt_sim_stopStart_Click);
            // 
            // bt_sim_swipeRight
            // 
            this.bt_sim_swipeRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_sim_swipeRight.FlatAppearance.BorderSize = 0;
            this.bt_sim_swipeRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bt_sim_swipeRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sim_swipeRight.Location = new System.Drawing.Point(332, 98);
            this.bt_sim_swipeRight.Name = "bt_sim_swipeRight";
            this.bt_sim_swipeRight.Size = new System.Drawing.Size(45, 197);
            this.bt_sim_swipeRight.TabIndex = 1;
            this.bt_sim_swipeRight.Text = "Swipe Right";
            this.bt_sim_swipeRight.UseVisualStyleBackColor = false;
            // 
            // bt_sim_swipeLeft
            // 
            this.bt_sim_swipeLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_sim_swipeLeft.FlatAppearance.BorderSize = 0;
            this.bt_sim_swipeLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bt_sim_swipeLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sim_swipeLeft.Location = new System.Drawing.Point(3, 98);
            this.bt_sim_swipeLeft.Name = "bt_sim_swipeLeft";
            this.bt_sim_swipeLeft.Size = new System.Drawing.Size(45, 197);
            this.bt_sim_swipeLeft.TabIndex = 0;
            this.bt_sim_swipeLeft.Text = "Swipe Left";
            this.bt_sim_swipeLeft.UseVisualStyleBackColor = false;
            // 
            // Simplified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.button_showMenu);
            this.Controls.Add(this.button_currentMenu);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.panel1);
            this.Name = "Simplified";
            this.Text = "Simplified";
            this.Load += new System.EventHandler(this.Simplified_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_sim_swipeRight;
        private System.Windows.Forms.Button bt_sim_swipeLeft;
        private System.Windows.Forms.Button bt_sim_stopStart;
        private System.Windows.Forms.Button button_showMenu;
        private System.Windows.Forms.Button button_currentMenu;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.PictureBox progressBar1;
        private System.Windows.Forms.Button bt_sim_addToFav;
        private System.Windows.Forms.Button bt_sim_addPlaylist;
        private System.Windows.Forms.Label label_addToFav;
        private System.Windows.Forms.Button bt_sim_openPlaylist;
        private System.Windows.Forms.Label label_addPlaylist;
    }
}