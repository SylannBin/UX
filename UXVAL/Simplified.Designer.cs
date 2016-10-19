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
            this.button_currentMenu = new System.Windows.Forms.Button();
            this.button_main = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_stopStart = new System.Windows.Forms.Button();
            this.bt_simpl_addToFavorite = new System.Windows.Forms.Button();
            this.button_stopNext = new System.Windows.Forms.Button();
            this.button_stopPrevious = new System.Windows.Forms.Button();
            this.button_tapScreen = new System.Windows.Forms.Button();
            this.button_swipeRight = new System.Windows.Forms.Button();
            this.button_swipeLeft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_currentMenu
            // 
            this.button_currentMenu.Location = new System.Drawing.Point(50, 1);
            this.button_currentMenu.Name = "button_currentMenu";
            this.button_currentMenu.Size = new System.Drawing.Size(333, 44);
            this.button_currentMenu.TabIndex = 3;
            this.button_currentMenu.Text = "Nom sous-menu en cours";
            this.button_currentMenu.UseVisualStyleBackColor = true;
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
            this.button_main.TabIndex = 2;
            this.button_main.UseVisualStyleBackColor = true;
            // 
            // button_menu
            // 
            this.button_menu.Location = new System.Drawing.Point(1, 596);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(65, 65);
            this.button_menu.TabIndex = 13;
            this.button_menu.Text = "Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 332);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 94);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Value = 33;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button_stopStart);
            this.panel1.Controls.Add(this.bt_simpl_addToFavorite);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.button_stopNext);
            this.panel1.Controls.Add(this.button_stopPrevious);
            this.panel1.Controls.Add(this.button_tapScreen);
            this.panel1.Controls.Add(this.button_swipeRight);
            this.panel1.Controls.Add(this.button_swipeLeft);
            this.panel1.Location = new System.Drawing.Point(2, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 610);
            this.panel1.TabIndex = 20;
            // 
            // button_stopStart
            // 
            this.button_stopStart.Location = new System.Drawing.Point(124, 281);
            this.button_stopStart.Name = "button_stopStart";
            this.button_stopStart.Size = new System.Drawing.Size(130, 38);
            this.button_stopStart.TabIndex = 21;
            this.button_stopStart.Text = "Reprendre lecture";
            this.button_stopStart.UseVisualStyleBackColor = true;
            // 
            // bt_simpl_addToFavorite
            // 
            this.bt_simpl_addToFavorite.BackColor = System.Drawing.Color.Transparent;
            this.bt_simpl_addToFavorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_simpl_addToFavorite.BackgroundImage")));
            this.bt_simpl_addToFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_simpl_addToFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_simpl_addToFavorite.Location = new System.Drawing.Point(314, 553);
            this.bt_simpl_addToFavorite.Name = "bt_simpl_addToFavorite";
            this.bt_simpl_addToFavorite.Size = new System.Drawing.Size(45, 45);
            this.bt_simpl_addToFavorite.TabIndex = 20;
            this.bt_simpl_addToFavorite.UseVisualStyleBackColor = false;
            // 
            // button_stopNext
            // 
            this.button_stopNext.Location = new System.Drawing.Point(279, 255);
            this.button_stopNext.Name = "button_stopNext";
            this.button_stopNext.Size = new System.Drawing.Size(70, 35);
            this.button_stopNext.TabIndex = 4;
            this.button_stopNext.Text = "Next";
            this.button_stopNext.UseVisualStyleBackColor = true;
            // 
            // button_stopPrevious
            // 
            this.button_stopPrevious.Location = new System.Drawing.Point(34, 259);
            this.button_stopPrevious.Name = "button_stopPrevious";
            this.button_stopPrevious.Size = new System.Drawing.Size(70, 35);
            this.button_stopPrevious.TabIndex = 3;
            this.button_stopPrevious.Text = "previous";
            this.button_stopPrevious.UseVisualStyleBackColor = true;
            // 
            // button_tapScreen
            // 
            this.button_tapScreen.Location = new System.Drawing.Point(120, 250);
            this.button_tapScreen.Name = "button_tapScreen";
            this.button_tapScreen.Size = new System.Drawing.Size(135, 44);
            this.button_tapScreen.TabIndex = 2;
            this.button_tapScreen.Text = "Tap Screen";
            this.button_tapScreen.UseVisualStyleBackColor = true;
            this.button_tapScreen.Click += new System.EventHandler(this.button_tapScreen_Click);
            // 
            // button_swipeRight
            // 
            this.button_swipeRight.Location = new System.Drawing.Point(287, 98);
            this.button_swipeRight.Name = "button_swipeRight";
            this.button_swipeRight.Size = new System.Drawing.Size(90, 30);
            this.button_swipeRight.TabIndex = 1;
            this.button_swipeRight.Text = "Swipe Right";
            this.button_swipeRight.UseVisualStyleBackColor = true;
            // 
            // button_swipeLeft
            // 
            this.button_swipeLeft.Location = new System.Drawing.Point(3, 98);
            this.button_swipeLeft.Name = "button_swipeLeft";
            this.button_swipeLeft.Size = new System.Drawing.Size(90, 30);
            this.button_swipeLeft.TabIndex = 0;
            this.button_swipeLeft.Text = "Swipe Left";
            this.button_swipeLeft.UseVisualStyleBackColor = true;
            // 
            // Simplified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_currentMenu);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.panel1);
            this.Name = "Simplified";
            this.Text = "Simplified";
            this.Load += new System.EventHandler(this.Simplified_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_currentMenu;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_stopNext;
        private System.Windows.Forms.Button button_stopPrevious;
        private System.Windows.Forms.Button button_tapScreen;
        private System.Windows.Forms.Button button_swipeRight;
        private System.Windows.Forms.Button button_swipeLeft;
        private System.Windows.Forms.Button bt_simpl_addToFavorite;
        private System.Windows.Forms.Button button_stopStart;
    }
}