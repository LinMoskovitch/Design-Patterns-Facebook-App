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
            this.buttonCollage = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonPages = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.pictureBoxCircleProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelTitleBar = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.PictureBoxCentralLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircleProfilePicture)).BeginInit();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCentralLogo)).BeginInit();
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
            this.panelMenu.Controls.Add(this.buttonCollage);
            this.panelMenu.Controls.Add(this.buttonPosts);
            this.panelMenu.Controls.Add(this.buttonPages);
            this.panelMenu.Controls.Add(this.buttonGroups);
            this.panelMenu.Controls.Add(this.buttonAlbums);
            this.panelMenu.Controls.Add(this.buttonUserInfo);
            this.panelMenu.Controls.Add(this.buttonLogin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 949);
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
            this.buttonLogout.Location = new System.Drawing.Point(0, 702);
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
            // buttonCollage
            // 
            this.buttonCollage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCollage.Enabled = false;
            this.buttonCollage.FlatAppearance.BorderSize = 0;
            this.buttonCollage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCollage.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCollage.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_collage_32;
            this.buttonCollage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCollage.Location = new System.Drawing.Point(0, 622);
            this.buttonCollage.Name = "buttonCollage";
            this.buttonCollage.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonCollage.Size = new System.Drawing.Size(280, 80);
            this.buttonCollage.TabIndex = 7;
            this.buttonCollage.Text = "  Collage";
            this.buttonCollage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCollage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCollage.UseVisualStyleBackColor = true;
            this.buttonCollage.Click += new System.EventHandler(this.buttonCollage_Click);
            // 
            // buttonPosts
            // 
            this.buttonPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPosts.Enabled = false;
            this.buttonPosts.FlatAppearance.BorderSize = 0;
            this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPosts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPosts.Image = global::BasicFacebookFeatures.Properties.Resources.icons8_facebook_like_32;
            this.buttonPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPosts.Location = new System.Drawing.Point(0, 542);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.buttonPosts.Size = new System.Drawing.Size(280, 80);
            this.buttonPosts.TabIndex = 6;
            this.buttonPosts.Text = "  Posts";
            this.buttonPosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPosts.UseVisualStyleBackColor = true;
            this.buttonPosts.Click += new System.EventHandler(this.buttonEvents_Click);
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
            this.panelTitleBar.Controls.Add(this.labelProfileName);
            this.panelTitleBar.Controls.Add(this.pictureBoxCircleProfilePicture);
            this.panelTitleBar.Controls.Add(this.labelTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(280, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1201, 142);
            this.panelTitleBar.TabIndex = 61;
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.Location = new System.Drawing.Point(1041, 66);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(78, 36);
            this.labelProfileName.TabIndex = 2;
            this.labelProfileName.Text = "label";
            this.labelProfileName.Visible = false;
            // 
            // pictureBoxCircleProfilePicture
            // 
            this.pictureBoxCircleProfilePicture.Location = new System.Drawing.Point(931, 40);
            this.pictureBoxCircleProfilePicture.Name = "pictureBoxCircleProfilePicture";
            this.pictureBoxCircleProfilePicture.Size = new System.Drawing.Size(84, 82);
            this.pictureBoxCircleProfilePicture.TabIndex = 1;
            this.pictureBoxCircleProfilePicture.TabStop = false;
            this.pictureBoxCircleProfilePicture.Visible = false;
            // 
            // labelTitleBar
            // 
            this.labelTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleBar.AutoSize = true;
            this.labelTitleBar.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleBar.ForeColor = System.Drawing.Color.White;
            this.labelTitleBar.Location = new System.Drawing.Point(533, 40);
            this.labelTitleBar.Name = "labelTitleBar";
            this.labelTitleBar.Size = new System.Drawing.Size(159, 57);
            this.labelTitleBar.TabIndex = 0;
            this.labelTitleBar.Text = "HOME";
            this.labelTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.PictureBoxCentralLogo);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(280, 142);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1201, 807);
            this.panelDesktopPanel.TabIndex = 62;
            // 
            // PictureBoxCentralLogo
            // 
            this.PictureBoxCentralLogo.BackColor = System.Drawing.Color.DarkGray;
            this.PictureBoxCentralLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxCentralLogo.Image = global::BasicFacebookFeatures.Properties.Resources.LEALON_logo;
            this.PictureBoxCentralLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxCentralLogo.Name = "PictureBoxCentralLogo";
            this.PictureBoxCentralLogo.Size = new System.Drawing.Size(1201, 807);
            this.PictureBoxCentralLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxCentralLogo.TabIndex = 0;
            this.PictureBoxCentralLogo.TabStop = false;
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1481, 949);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1507, 1020);
            this.MinimumSize = new System.Drawing.Size(1507, 1020);
            this.Name = "FacebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircleProfilePicture)).EndInit();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCentralLogo)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCollage;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Button buttonPages;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitleBar;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.PictureBox PictureBoxCentralLogo;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxCircleProfilePicture;
    }
}

