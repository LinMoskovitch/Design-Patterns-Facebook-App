namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panelChosenOptionDisplay = new System.Windows.Forms.Panel();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.flowLayoutPanelOptionsMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddNewPost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.flowLayoutPanelOptionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(16, 15);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(194, 28);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(16, 51);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(194, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(218, 25);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(148, 140);
            this.pictureBoxProfilePicture.TabIndex = 53;
            this.pictureBoxProfilePicture.TabStop = false;
            this.pictureBoxProfilePicture.Visible = false;
            this.pictureBoxProfilePicture.Click += new System.EventHandler(this.pictureBoxProfilePicture_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Cursor = System.Windows.Forms.Cursors.No;
            this.labelFullName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(447, 108);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(0, 47);
            this.labelFullName.TabIndex = 54;
            // 
            // panelChosenOptionDisplay
            // 
            this.panelChosenOptionDisplay.Location = new System.Drawing.Point(216, 170);
            this.panelChosenOptionDisplay.Name = "panelChosenOptionDisplay";
            this.panelChosenOptionDisplay.Size = new System.Drawing.Size(903, 503);
            this.panelChosenOptionDisplay.TabIndex = 55;
            // 
            // buttonPosts
            // 
            this.buttonPosts.AutoSize = true;
            this.buttonPosts.Location = new System.Drawing.Point(3, 35);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(150, 26);
            this.buttonPosts.TabIndex = 56;
            this.buttonPosts.Text = "Posts";
            this.buttonPosts.UseVisualStyleBackColor = true;
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.AutoSize = true;
            this.buttonAlbums.Location = new System.Drawing.Point(3, 67);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(150, 26);
            this.buttonAlbums.TabIndex = 57;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            // 
            // buttonGroups
            // 
            this.buttonGroups.AutoSize = true;
            this.buttonGroups.Location = new System.Drawing.Point(3, 99);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(150, 26);
            this.buttonGroups.TabIndex = 58;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = true;
            // 
            // buttonFriends
            // 
            this.buttonFriends.AutoSize = true;
            this.buttonFriends.Location = new System.Drawing.Point(3, 131);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(150, 26);
            this.buttonFriends.TabIndex = 59;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelOptionsMenu
            // 
            this.flowLayoutPanelOptionsMenu.Controls.Add(this.buttonAddNewPost);
            this.flowLayoutPanelOptionsMenu.Controls.Add(this.buttonPosts);
            this.flowLayoutPanelOptionsMenu.Controls.Add(this.buttonAlbums);
            this.flowLayoutPanelOptionsMenu.Controls.Add(this.buttonGroups);
            this.flowLayoutPanelOptionsMenu.Controls.Add(this.buttonFriends);
            this.flowLayoutPanelOptionsMenu.Location = new System.Drawing.Point(16, 170);
            this.flowLayoutPanelOptionsMenu.Name = "flowLayoutPanelOptionsMenu";
            this.flowLayoutPanelOptionsMenu.Size = new System.Drawing.Size(194, 160);
            this.flowLayoutPanelOptionsMenu.TabIndex = 60;
            // 
            // buttonAddNewPost
            // 
            this.buttonAddNewPost.AutoSize = true;
            this.buttonAddNewPost.Location = new System.Drawing.Point(3, 3);
            this.buttonAddNewPost.Name = "buttonAddNewPost";
            this.buttonAddNewPost.Size = new System.Drawing.Size(150, 26);
            this.buttonAddNewPost.TabIndex = 60;
            this.buttonAddNewPost.Text = "Add new post";
            this.buttonAddNewPost.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 675);
            this.Controls.Add(this.flowLayoutPanelOptionsMenu);
            this.Controls.Add(this.panelChosenOptionDisplay);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.flowLayoutPanelOptionsMenu.ResumeLayout(false);
            this.flowLayoutPanelOptionsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panelChosenOptionDisplay;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOptionsMenu;
        private System.Windows.Forms.Button buttonAddNewPost;
    }
}

