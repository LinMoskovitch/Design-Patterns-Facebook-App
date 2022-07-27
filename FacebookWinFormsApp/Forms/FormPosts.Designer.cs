
namespace BasicFacebookFeatures.Forms
{
    partial class FormPosts
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
            this.listBoxPostsList = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.buttonPostNewStatus = new System.Windows.Forms.Button();
            this.pictureBoxPostPhotoDisplay = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.listBoxCommentsList = new System.Windows.Forms.ListBox();
            this.panelPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPostsList
            // 
            this.listBoxPostsList.FormattingEnabled = true;
            this.listBoxPostsList.ItemHeight = 25;
            this.listBoxPostsList.Location = new System.Drawing.Point(107, 44);
            this.listBoxPostsList.Name = "listBoxPostsList";
            this.listBoxPostsList.Size = new System.Drawing.Size(507, 204);
            this.listBoxPostsList.TabIndex = 3;
            this.listBoxPostsList.SelectedValueChanged += new System.EventHandler(this.listBoxEventsList_SelectedValueChanged);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(107, 551);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchPosts.TabIndex = 0;
            this.buttonFetchPosts.Text = "Fetch posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // panelPosts
            // 
            this.panelPosts.Controls.Add(this.listBoxCommentsList);
            this.panelPosts.Controls.Add(this.textBoxStatus);
            this.panelPosts.Controls.Add(this.pictureBoxPostPhotoDisplay);
            this.panelPosts.Controls.Add(this.buttonPostNewStatus);
            this.panelPosts.Controls.Add(this.listBoxPostsList);
            this.panelPosts.Controls.Add(this.buttonFetchPosts);
            this.panelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPosts.Location = new System.Drawing.Point(0, 0);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(1514, 794);
            this.panelPosts.TabIndex = 1;
            // 
            // buttonPostNewStatus
            // 
            this.buttonPostNewStatus.Location = new System.Drawing.Point(1298, 655);
            this.buttonPostNewStatus.Name = "buttonPostNewStatus";
            this.buttonPostNewStatus.Size = new System.Drawing.Size(204, 55);
            this.buttonPostNewStatus.TabIndex = 5;
            this.buttonPostNewStatus.Text = "Post a new status";
            this.buttonPostNewStatus.UseVisualStyleBackColor = true;
            this.buttonPostNewStatus.Click += new System.EventHandler(this.buttonAddNewPost_Click);
            // 
            // pictureBoxPostPhotoDisplay
            // 
            this.pictureBoxPostPhotoDisplay.Location = new System.Drawing.Point(801, 44);
            this.pictureBoxPostPhotoDisplay.Name = "pictureBoxPostPhotoDisplay";
            this.pictureBoxPostPhotoDisplay.Size = new System.Drawing.Size(481, 454);
            this.pictureBoxPostPhotoDisplay.TabIndex = 6;
            this.pictureBoxPostPhotoDisplay.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(107, 655);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(1175, 55);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // listBoxCommentsList
            // 
            this.listBoxCommentsList.FormattingEnabled = true;
            this.listBoxCommentsList.ItemHeight = 25;
            this.listBoxCommentsList.Location = new System.Drawing.Point(107, 294);
            this.listBoxCommentsList.Name = "listBoxCommentsList";
            this.listBoxCommentsList.Size = new System.Drawing.Size(507, 204);
            this.listBoxCommentsList.TabIndex = 8;
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 794);
            this.Controls.Add(this.panelPosts);
            this.Name = "FormPosts";
            this.Text = "Events";
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPostsList;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.Button buttonPostNewStatus;
        private System.Windows.Forms.PictureBox pictureBoxPostPhotoDisplay;
        private System.Windows.Forms.ListBox listBoxCommentsList;
        private System.Windows.Forms.TextBox textBoxStatus;
    }
}