namespace Abdal_Security_Group_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            radMenu1 = new Telerik.WinControls.UI.RadMenu();
            menuItem_about_us = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_donate = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_github = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_gitlab = new Telerik.WinControls.UI.RadMenuItem();
            desk_alert = new Telerik.WinControls.UI.RadDesktopAlert(components);
            bg_worker = new System.ComponentModel.BackgroundWorker();
            btn_start = new Telerik.WinControls.UI.RadButton();
            radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            radRepeatButton1 = new Telerik.WinControls.UI.RadRepeatButton();
            radButton3 = new Telerik.WinControls.UI.RadButton();
            attackStatusProgressBar = new Telerik.WinControls.UI.RadProgressBar();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radButton2 = new Telerik.WinControls.UI.RadButton();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            tb_url_target = new Telerik.WinControls.UI.RadTextBox();
            radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            list_attack_log = new ListBox();
            radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            openFileDialogUserName = new OpenFileDialog();
            openFileDialogPassword = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            list_failed_attack = new ListBox();
            list_hacked_accounts = new ListBox();
            ((System.ComponentModel.ISupportInitialize)radMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).BeginInit();
            radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radRepeatButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attackStatusProgressBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_url_target).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox2).BeginInit();
            radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGroupBox3).BeginInit();
            radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radGroupBox4).BeginInit();
            radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radMenu1
            // 
            radMenu1.BackColor = Color.Transparent;
            radMenu1.Dock = DockStyle.Bottom;
            radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_about_us, menuItem_donate, radMenuItem3 });
            radMenu1.Location = new Point(0, 452);
            radMenu1.Name = "radMenu1";
            radMenu1.Size = new Size(808, 28);
            radMenu1.TabIndex = 0;
            radMenu1.ThemeName = "VisualStudio2022Dark";
            // 
            // menuItem_about_us
            // 
            menuItem_about_us.Image = Properties.Resources.Book_Earth_16;
            menuItem_about_us.Name = "menuItem_about_us";
            menuItem_about_us.Text = "About Us";
            menuItem_about_us.Click += menuItem_about_us_Click;
            // 
            // menuItem_donate
            // 
            menuItem_donate.Image = Properties.Resources.coin_5_32;
            menuItem_donate.Name = "menuItem_donate";
            menuItem_donate.Text = "Donate";
            menuItem_donate.Click += menuItem_donate_Click;
            // 
            // radMenuItem3
            // 
            radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_github, menuItem_gitlab });
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "Source Code";
            // 
            // menuItem_github
            // 
            menuItem_github.Image = Properties.Resources.github;
            menuItem_github.Name = "menuItem_github";
            menuItem_github.Text = "Github";
            menuItem_github.Click += menuItem_github_Click;
            // 
            // menuItem_gitlab
            // 
            menuItem_gitlab.Image = Properties.Resources.gitlab_icon_rgb;
            menuItem_gitlab.Name = "menuItem_gitlab";
            menuItem_gitlab.Text = "Gitlab";
            menuItem_gitlab.Click += menuItem_gitlab_Click;
            // 
            // desk_alert
            // 
            desk_alert.ThemeName = "";
            // 
            // bg_worker
            // 
            bg_worker.DoWork += bg_worker_DoWork;
            bg_worker.RunWorkerCompleted += bg_worker_RunWorkerCompleted;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(302, 77);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(87, 24);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.ThemeName = "VisualStudio2022Dark";
            btn_start.Click += btn_start_Click;
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.BackColor = Color.Transparent;
            radGroupBox1.Controls.Add(radRepeatButton1);
            radGroupBox1.Controls.Add(radButton3);
            radGroupBox1.Controls.Add(attackStatusProgressBar);
            radGroupBox1.Controls.Add(radLabel1);
            radGroupBox1.Controls.Add(radButton2);
            radGroupBox1.Controls.Add(radButton1);
            radGroupBox1.Controls.Add(btn_start);
            radGroupBox1.Controls.Add(tb_url_target);
            radGroupBox1.HeaderText = "Attack Configuration";
            radGroupBox1.Location = new Point(284, 12);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new Size(512, 118);
            radGroupBox1.TabIndex = 2;
            radGroupBox1.Text = "Attack Configuration";
            radGroupBox1.ThemeName = "Windows8";
            radGroupBox1.Click += radGroupBox1_Click;
            // 
            // radRepeatButton1
            // 
            radRepeatButton1.Location = new Point(396, 77);
            radRepeatButton1.Name = "radRepeatButton1";
            radRepeatButton1.Size = new Size(62, 24);
            radRepeatButton1.TabIndex = 8;
            radRepeatButton1.Text = "Stop";
            radRepeatButton1.ThemeName = "VisualStudio2022Dark";
            radRepeatButton1.Click += radRepeatButton1_Click;
            // 
            // radButton3
            // 
            radButton3.Location = new Point(465, 77);
            radButton3.Name = "radButton3";
            radButton3.Size = new Size(42, 24);
            radButton3.TabIndex = 7;
            radButton3.Text = "Exit";
            radButton3.ThemeName = "VisualStudio2022Dark";
            radButton3.Click += radButton3_Click;
            // 
            // attackStatusProgressBar
            // 
            attackStatusProgressBar.Location = new Point(7, 77);
            attackStatusProgressBar.Name = "attackStatusProgressBar";
            attackStatusProgressBar.Size = new Size(288, 24);
            attackStatusProgressBar.TabIndex = 6;
            attackStatusProgressBar.Text = "Attack Status";
            attackStatusProgressBar.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(7, 23);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(74, 21);
            radLabel1.TabIndex = 5;
            radLabel1.Text = "Target URL";
            radLabel1.ThemeName = "VisualStudio2022Dark";
            // 
            // radButton2
            // 
            radButton2.Location = new Point(397, 43);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(110, 24);
            radButton2.TabIndex = 4;
            radButton2.Text = "Password File";
            radButton2.ThemeName = "VisualStudio2022Dark";
            radButton2.Click += radButton2_Click;
            // 
            // radButton1
            // 
            radButton1.Location = new Point(281, 43);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(110, 24);
            radButton1.TabIndex = 3;
            radButton1.Text = "UserName File";
            radButton1.ThemeName = "VisualStudio2022Dark";
            radButton1.Click += radButton1_Click;
            // 
            // tb_url_target
            // 
            tb_url_target.Location = new Point(5, 45);
            tb_url_target.Name = "tb_url_target";
            tb_url_target.NullText = "example : https://ebrasha.com";
            tb_url_target.Size = new Size(270, 22);
            tb_url_target.TabIndex = 1;
            tb_url_target.ThemeName = "VisualStudio2022Dark";
            // 
            // radGroupBox2
            // 
            radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox2.BackColor = Color.Transparent;
            radGroupBox2.Controls.Add(list_attack_log);
            radGroupBox2.ForeColor = Color.Tomato;
            radGroupBox2.HeaderMargin = new Padding(1);
            radGroupBox2.HeaderText = "Attack Log";
            radGroupBox2.Location = new Point(284, 136);
            radGroupBox2.Name = "radGroupBox2";
            radGroupBox2.Size = new Size(512, 104);
            radGroupBox2.TabIndex = 3;
            radGroupBox2.Text = "Attack Log";
            radGroupBox2.ThemeName = "VisualStudio2022Dark";
            // 
            // list_attack_log
            // 
            list_attack_log.BackColor = Color.FromArgb(36, 36, 36);
            list_attack_log.BorderStyle = BorderStyle.None;
            list_attack_log.Dock = DockStyle.Fill;
            list_attack_log.ForeColor = Color.Tomato;
            list_attack_log.FormattingEnabled = true;
            list_attack_log.ItemHeight = 15;
            list_attack_log.Location = new Point(2, 18);
            list_attack_log.Name = "list_attack_log";
            list_attack_log.Size = new Size(508, 84);
            list_attack_log.TabIndex = 8;
            // 
            // radGroupBox3
            // 
            radGroupBox3.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox3.Controls.Add(list_hacked_accounts);
            radGroupBox3.ForeColor = Color.FromArgb(128, 255, 128);
            radGroupBox3.HeaderMargin = new Padding(1);
            radGroupBox3.HeaderText = "Hacked Accounts";
            radGroupBox3.Location = new Point(284, 361);
            radGroupBox3.Name = "radGroupBox3";
            radGroupBox3.Size = new Size(512, 85);
            radGroupBox3.TabIndex = 4;
            radGroupBox3.Text = "Hacked Accounts";
            radGroupBox3.ThemeName = "VisualStudio2022Dark";
            // 
            // radGroupBox4
            // 
            radGroupBox4.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox4.Controls.Add(list_failed_attack);
            radGroupBox4.ForeColor = Color.Red;
            radGroupBox4.HeaderMargin = new Padding(1);
            radGroupBox4.HeaderText = "Failed Attack";
            radGroupBox4.Location = new Point(284, 246);
            radGroupBox4.Name = "radGroupBox4";
            radGroupBox4.Size = new Size(512, 109);
            radGroupBox4.TabIndex = 5;
            radGroupBox4.Text = "Failed Attack";
            radGroupBox4.ThemeName = "VisualStudio2022Dark";
            // 
            // openFileDialogUserName
            // 
            openFileDialogUserName.FileName = "openFileDialog1";
            // 
            // openFileDialogPassword
            // 
            openFileDialogPassword.FileName = "openFileDialog1";
            openFileDialogPassword.FileOk += openFileDialogPassword_FileOk;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._3;
            pictureBox1.Location = new Point(15, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(42, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // list_failed_attack
            // 
            list_failed_attack.BackColor = Color.FromArgb(36, 36, 36);
            list_failed_attack.BorderStyle = BorderStyle.None;
            list_failed_attack.Dock = DockStyle.Fill;
            list_failed_attack.ForeColor = Color.White;
            list_failed_attack.FormattingEnabled = true;
            list_failed_attack.ItemHeight = 15;
            list_failed_attack.Location = new Point(2, 18);
            list_failed_attack.Name = "list_failed_attack";
            list_failed_attack.Size = new Size(508, 89);
            list_failed_attack.TabIndex = 0;
            // 
            // list_hacked_accounts
            // 
            list_hacked_accounts.BackColor = Color.FromArgb(36, 36, 36);
            list_hacked_accounts.BorderStyle = BorderStyle.None;
            list_hacked_accounts.Dock = DockStyle.Fill;
            list_hacked_accounts.ForeColor = Color.White;
            list_hacked_accounts.FormattingEnabled = true;
            list_hacked_accounts.ItemHeight = 15;
            list_hacked_accounts.Location = new Point(2, 18);
            list_hacked_accounts.Name = "list_hacked_accounts";
            list_hacked_accounts.Size = new Size(508, 65);
            list_hacked_accounts.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(808, 480);
            Controls.Add(radGroupBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(radGroupBox4);
            Controls.Add(radGroupBox2);
            Controls.Add(radGroupBox1);
            Controls.Add(radMenu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abdal WP XmlRPC BruteForce";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)radMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).EndInit();
            radGroupBox1.ResumeLayout(false);
            radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radRepeatButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)attackStatusProgressBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_url_target).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox2).EndInit();
            radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGroupBox3).EndInit();
            radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radGroupBox4).EndInit();
            radGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuItem_about_us;
        private Telerik.WinControls.UI.RadMenuItem menuItem_donate;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem menuItem_github;
        private Telerik.WinControls.UI.RadMenuItem menuItem_gitlab;
        private Telerik.WinControls.UI.RadDesktopAlert desk_alert;
        private System.ComponentModel.BackgroundWorker bg_worker;
        private Telerik.WinControls.UI.RadButton btn_start;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private Telerik.WinControls.UI.RadTextBox tb_url_target;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadProgressBar attackStatusProgressBar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private OpenFileDialog openFileDialogUserName;
        private OpenFileDialog openFileDialogPassword;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadRepeatButton radRepeatButton1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox list_attack_log;
        private ListBox list_failed_attack;
        private ListBox list_hacked_accounts;
    }
}
