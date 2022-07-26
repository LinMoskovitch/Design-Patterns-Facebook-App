using System.Drawing;

namespace BasicFacebookFeatures
{
    partial class FacebookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookForm));
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonFeature2 = new System.Windows.Forms.Button();
            this.buttonFeature1 = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonPages = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Location = new System.Drawing.Point(357, 182);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(0, 0);
            this.panelUserInfo.TabIndex = 55;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonFeature2);
            this.panelMenu.Controls.Add(this.buttonFeature1);
            this.panelMenu.Controls.Add(this.buttonEvents);
            this.panelMenu.Controls.Add(this.buttonPages);
            this.panelMenu.Controls.Add(this.buttonGroups);
            this.panelMenu.Controls.Add(this.buttonAlbums);
            this.panelMenu.Controls.Add(this.buttonUserInfo);
            this.panelMenu.Controls.Add(this.buttonLogin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 951);
            this.panelMenu.TabIndex = 60;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.Image = global::BasicFacebookFeatures.Properties.Resources.logout_32;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 782);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(280, 80);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "  Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonFeature2
            // 
            this.buttonFeature2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFeature2.Enabled = false;
            this.buttonFeature2.FlatAppearance.BorderSize = 0;
            this.buttonFeature2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFeature2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeature2.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFeature2.Image = global::BasicFacebookFeatures.Properties.Resources.events_32;
            this.buttonFeature2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFeature2.Location = new System.Drawing.Point(0, 702);
            this.buttonFeature2.Name = "buttonFeature2";
            this.buttonFeature2.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonFeature2.Size = new System.Drawing.Size(280, 80);
            this.buttonFeature2.TabIndex = 8;
            this.buttonFeature2.Text = "  Feature 2";
            this.buttonFeature2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFeature2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFeature2.UseVisualStyleBackColor = true;
            this.buttonFeature2.Click += new System.EventHandler(this.buttonFeature2_Click);
            // 
            // buttonFeature1
            // 
            this.buttonFeature1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFeature1.Enabled = false;
            this.buttonFeature1.FlatAppearance.BorderSize = 0;
            this.buttonFeature1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFeature1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeature1.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFeature1.Image = global::BasicFacebookFeatures.Properties.Resources.events_32;
            this.buttonFeature1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFeature1.Location = new System.Drawing.Point(0, 622);
            this.buttonFeature1.Name = "buttonFeature1";
            this.buttonFeature1.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonFeature1.Size = new System.Drawing.Size(280, 80);
            this.buttonFeature1.TabIndex = 7;
            this.buttonFeature1.Text = "  Feature 1";
            this.buttonFeature1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFeature1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFeature1.UseVisualStyleBackColor = true;
            this.buttonFeature1.Click += new System.EventHandler(this.buttonFeature1_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEvents.Enabled = false;
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEvents.Image = global::BasicFacebookFeatures.Properties.Resources.events_32;
            this.buttonEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.Location = new System.Drawing.Point(0, 542);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonEvents.Size = new System.Drawing.Size(280, 80);
            this.buttonEvents.TabIndex = 6;
            this.buttonEvents.Text = "  Events";
            this.buttonEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonPages
            // 
            this.buttonPages.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPages.Enabled = false;
            this.buttonPages.FlatAppearance.BorderSize = 0;
            this.buttonPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPages.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPages.Image = global::BasicFacebookFeatures.Properties.Resources.page_32;
            this.buttonPages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPages.Location = new System.Drawing.Point(0, 462);
            this.buttonPages.Name = "buttonPages";
            this.buttonPages.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonPages.Size = new System.Drawing.Size(280, 80);
            this.buttonPages.TabIndex = 5;
            this.buttonPages.Text = "  Pages";
            this.buttonPages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPages.UseVisualStyleBackColor = true;
            this.buttonPages.Click += new System.EventHandler(this.buttonPages_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroups.Enabled = false;
            this.buttonGroups.FlatAppearance.BorderSize = 0;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGroups.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGroups.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_google_groups_32;
            this.buttonGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.Location = new System.Drawing.Point(0, 382);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonGroups.Size = new System.Drawing.Size(280, 80);
            this.buttonGroups.TabIndex = 4;
            this.buttonGroups.Text = "  Groups";
            this.buttonGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlbums.Enabled = false;
            this.buttonAlbums.FlatAppearance.BorderSize = 0;
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbums.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.albums_32;
            this.buttonAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.Location = new System.Drawing.Point(0, 302);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonAlbums.Size = new System.Drawing.Size(280, 80);
            this.buttonAlbums.TabIndex = 3;
            this.buttonAlbums.Text = "  Albums";
            this.buttonAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUserInfo.Enabled = false;
            this.buttonUserInfo.FlatAppearance.BorderSize = 0;
            this.buttonUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUserInfo.Image = global::BasicFacebookFeatures.Properties.Resources.user_32;
            this.buttonUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserInfo.Location = new System.Drawing.Point(0, 222);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonUserInfo.Size = new System.Drawing.Size(280, 80);
            this.buttonUserInfo.TabIndex = 2;
            this.buttonUserInfo.Text = "  User Info";
            this.buttonUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUserInfo.UseVisualStyleBackColor = true;
            this.buttonUserInfo.Click += new System.EventHandler(this.buttonUserInfo_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogin.Image = global::BasicFacebookFeatures.Properties.Resources.login_32;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(0, 142);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonLogin.Size = new System.Drawing.Size(280, 80);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "  Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(280, 142);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.labelTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(280, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1250, 142);
            this.panelTitleBar.TabIndex = 61;
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleBar.AutoSize = true;
            this.labelTitleBar.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleBar.ForeColor = System.Drawing.Color.White;
            this.labelTitleBar.Location = new System.Drawing.Point(558, 40);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Size = new System.Drawing.Size(159, 57);
            this.labelTitleBar.TabIndex = 0;
            this.labelTitleBar.Text = "HOME";
            this.labelTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(280, 142);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1250, 809);
            this.panelDesktopPanel.TabIndex = 62;
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1530, 951);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUserInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1556, 1022);
            this.MinimumSize = new System.Drawing.Size(1556, 1022);
            this.Name = "FacebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonFeature1;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonPages;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button buttonFeature2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitleBar;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}

