
namespace BasicFacebookFeatures.Forms
{
    partial class FormUserInfo
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
            this.labelUserInfoWelcome = new System.Windows.Forms.Label();
            this.labelUserInfoGender = new System.Windows.Forms.Label();
            this.labelUserInfoEmail = new System.Windows.Forms.Label();
            this.labelUserBirthDate = new System.Windows.Forms.Label();
            this.labelUserInfoName = new System.Windows.Forms.Label();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.pictureBoxUserInfoProfilePicture = new System.Windows.Forms.PictureBox();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserInfoProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserInfoWelcome
            // 
            this.labelUserInfoWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserInfoWelcome.AutoSize = true;
            this.labelUserInfoWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInfoWelcome.Location = new System.Drawing.Point(541, 91);
            this.labelUserInfoWelcome.Name = "labelUserInfoWelcome";
            this.labelUserInfoWelcome.Size = new System.Drawing.Size(337, 76);
            this.labelUserInfoWelcome.TabIndex = 8;
            this.labelUserInfoWelcome.Text = "Welcome ";
            // 
            // labelUserInfoGender
            // 
            this.labelUserInfoGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserInfoGender.AutoSize = true;
            this.labelUserInfoGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInfoGender.Location = new System.Drawing.Point(60, 240);
            this.labelUserInfoGender.Name = "labelUserInfoGender";
            this.labelUserInfoGender.Padding = new System.Windows.Forms.Padding(11, 20, 0, 0);
            this.labelUserInfoGender.Size = new System.Drawing.Size(149, 56);
            this.labelUserInfoGender.TabIndex = 4;
            this.labelUserInfoGender.Text = "Gender: ";
            // 
            // labelUserInfoEmail
            // 
            this.labelUserInfoEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserInfoEmail.AutoSize = true;
            this.labelUserInfoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInfoEmail.Location = new System.Drawing.Point(60, 114);
            this.labelUserInfoEmail.Name = "labelUserInfoEmail";
            this.labelUserInfoEmail.Padding = new System.Windows.Forms.Padding(11, 20, 0, 0);
            this.labelUserInfoEmail.Size = new System.Drawing.Size(122, 56);
            this.labelUserInfoEmail.TabIndex = 3;
            this.labelUserInfoEmail.Text = "Email: ";
            // 
            // labelUserBirthDate
            // 
            this.labelUserBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserBirthDate.AutoSize = true;
            this.labelUserBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserBirthDate.Location = new System.Drawing.Point(60, 175);
            this.labelUserBirthDate.Name = "labelUserBirthDate";
            this.labelUserBirthDate.Padding = new System.Windows.Forms.Padding(11, 20, 0, 0);
            this.labelUserBirthDate.Size = new System.Drawing.Size(185, 56);
            this.labelUserBirthDate.TabIndex = 5;
            this.labelUserBirthDate.Text = "Birth Date: ";
            // 
            // labelUserInfoName
            // 
            this.labelUserInfoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserInfoName.AutoSize = true;
            this.labelUserInfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInfoName.Location = new System.Drawing.Point(60, 51);
            this.labelUserInfoName.Name = "labelUserInfoName";
            this.labelUserInfoName.Padding = new System.Windows.Forms.Padding(11, 20, 0, 0);
            this.labelUserInfoName.Size = new System.Drawing.Size(182, 56);
            this.labelUserInfoName.TabIndex = 2;
            this.labelUserInfoName.Text = "Full name: ";
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUserInfo.Controls.Add(this.labelUserInfoName);
            this.panelUserInfo.Controls.Add(this.labelUserBirthDate);
            this.panelUserInfo.Controls.Add(this.labelUserInfoEmail);
            this.panelUserInfo.Controls.Add(this.labelUserInfoGender);
            this.panelUserInfo.Location = new System.Drawing.Point(636, 246);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(692, 504);
            this.panelUserInfo.TabIndex = 10;
            // 
            // pictureBoxUserInfoProfilePicture
            // 
            this.pictureBoxUserInfoProfilePicture.Location = new System.Drawing.Point(63, 246);
            this.pictureBoxUserInfoProfilePicture.Name = "pictureBoxUserInfoProfilePicture";
            this.pictureBoxUserInfoProfilePicture.Size = new System.Drawing.Size(344, 336);
            this.pictureBoxUserInfoProfilePicture.TabIndex = 7;
            this.pictureBoxUserInfoProfilePicture.TabStop = false;
            this.pictureBoxUserInfoProfilePicture.Visible = false;
            // 
            // FormUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 945);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.labelUserInfoWelcome);
            this.Controls.Add(this.pictureBoxUserInfoProfilePicture);
            this.MaximumSize = new System.Drawing.Size(1507, 1016);
            this.MinimumSize = new System.Drawing.Size(1507, 1016);
            this.Name = "FormUserInfo";
            this.Text = "User Info";
            this.Load += new System.EventHandler(this.FormUserInfo_Load);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserInfoProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserInfoWelcome;
        private System.Windows.Forms.PictureBox pictureBoxUserInfoProfilePicture;
        private System.Windows.Forms.Label labelUserInfoGender;
        private System.Windows.Forms.Label labelUserInfoEmail;
        private System.Windows.Forms.Label labelUserBirthDate;
        private System.Windows.Forms.Label labelUserInfoName;
        private System.Windows.Forms.Panel panelUserInfo;
    }
}