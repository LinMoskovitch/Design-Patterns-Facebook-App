
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSortByDate = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByLikes = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByComments = new System.Windows.Forms.RadioButton();
            this.listBoxCommentsList = new System.Windows.Forms.ListBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxPostPhotoDisplay = new System.Windows.Forms.PictureBox();
            this.buttonPostNewStatus = new System.Windows.Forms.Button();
            this.buttonSortPosts = new System.Windows.Forms.Button();
            this.panelPosts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPostsList
            // 
            this.listBoxPostsList.FormattingEnabled = true;
            this.listBoxPostsList.ItemHeight = 16;
            this.listBoxPostsList.Location = new System.Drawing.Point(71, 28);
            this.listBoxPostsList.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPostsList.Name = "listBoxPostsList";
            this.listBoxPostsList.Size = new System.Drawing.Size(339, 132);
            this.listBoxPostsList.TabIndex = 3;
            this.listBoxPostsList.SelectedValueChanged += new System.EventHandler(this.listBoxEventsList_SelectedValueChanged);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(71, 353);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(136, 51);
            this.buttonFetchPosts.TabIndex = 0;
            this.buttonFetchPosts.Text = "Fetch posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // panelPosts
            // 
            this.panelPosts.Controls.Add(this.groupBox1);
            this.panelPosts.Controls.Add(this.listBoxCommentsList);
            this.panelPosts.Controls.Add(this.textBoxStatus);
            this.panelPosts.Controls.Add(this.pictureBoxPostPhotoDisplay);
            this.panelPosts.Controls.Add(this.buttonPostNewStatus);
            this.panelPosts.Controls.Add(this.listBoxPostsList);
            this.panelPosts.Controls.Add(this.buttonFetchPosts);
            this.panelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPosts.Location = new System.Drawing.Point(0, 0);
            this.panelPosts.Margin = new System.Windows.Forms.Padding(2);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(1009, 508);
            this.panelPosts.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSortPosts);
            this.groupBox1.Controls.Add(this.radioButtonSortByDate);
            this.groupBox1.Controls.Add(this.radioButtonSortByLikes);
            this.groupBox1.Controls.Add(this.radioButtonSortByComments);
            this.groupBox1.Location = new System.Drawing.Point(415, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 154);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort posts by";
            // 
            // radioButtonSortByDate
            // 
            this.radioButtonSortByDate.AutoSize = true;
            this.radioButtonSortByDate.Checked = true;
            this.radioButtonSortByDate.Location = new System.Drawing.Point(6, 21);
            this.radioButtonSortByDate.Name = "radioButtonSortByDate";
            this.radioButtonSortByDate.Size = new System.Drawing.Size(155, 20);
            this.radioButtonSortByDate.TabIndex = 9;
            this.radioButtonSortByDate.TabStop = true;
            this.radioButtonSortByDate.Text = "Date posted (Default)";
            this.radioButtonSortByDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortByLikes
            // 
            this.radioButtonSortByLikes.AutoSize = true;
            this.radioButtonSortByLikes.Location = new System.Drawing.Point(6, 47);
            this.radioButtonSortByLikes.Name = "radioButtonSortByLikes";
            this.radioButtonSortByLikes.Size = new System.Drawing.Size(93, 20);
            this.radioButtonSortByLikes.TabIndex = 10;
            this.radioButtonSortByLikes.Text = "Most Liked";
            this.radioButtonSortByLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSortByLikes.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortByComments
            // 
            this.radioButtonSortByComments.AutoSize = true;
            this.radioButtonSortByComments.Location = new System.Drawing.Point(6, 73);
            this.radioButtonSortByComments.Name = "radioButtonSortByComments";
            this.radioButtonSortByComments.Size = new System.Drawing.Size(133, 20);
            this.radioButtonSortByComments.TabIndex = 11;
            this.radioButtonSortByComments.Text = "Most Commented";
            this.radioButtonSortByComments.UseVisualStyleBackColor = true;
            // 
            // listBoxCommentsList
            // 
            this.listBoxCommentsList.FormattingEnabled = true;
            this.listBoxCommentsList.ItemHeight = 16;
            this.listBoxCommentsList.Location = new System.Drawing.Point(71, 188);
            this.listBoxCommentsList.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCommentsList.Name = "listBoxCommentsList";
            this.listBoxCommentsList.Size = new System.Drawing.Size(339, 132);
            this.listBoxCommentsList.TabIndex = 8;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(71, 419);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(785, 37);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // pictureBoxPostPhotoDisplay
            // 
            this.pictureBoxPostPhotoDisplay.Location = new System.Drawing.Point(585, 28);
            this.pictureBoxPostPhotoDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPostPhotoDisplay.Name = "pictureBoxPostPhotoDisplay";
            this.pictureBoxPostPhotoDisplay.Size = new System.Drawing.Size(321, 291);
            this.pictureBoxPostPhotoDisplay.TabIndex = 6;
            this.pictureBoxPostPhotoDisplay.TabStop = false;
            // 
            // buttonPostNewStatus
            // 
            this.buttonPostNewStatus.Location = new System.Drawing.Point(865, 419);
            this.buttonPostNewStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPostNewStatus.Name = "buttonPostNewStatus";
            this.buttonPostNewStatus.Size = new System.Drawing.Size(136, 35);
            this.buttonPostNewStatus.TabIndex = 5;
            this.buttonPostNewStatus.Text = "Post a new status";
            this.buttonPostNewStatus.UseVisualStyleBackColor = true;
            this.buttonPostNewStatus.Click += new System.EventHandler(this.buttonAddNewPost_Click);
            // 
            // buttonSortPosts
            // 
            this.buttonSortPosts.Location = new System.Drawing.Point(84, 125);
            this.buttonSortPosts.Name = "buttonSortPosts";
            this.buttonSortPosts.Size = new System.Drawing.Size(75, 23);
            this.buttonSortPosts.TabIndex = 12;
            this.buttonSortPosts.Text = "Sort posts";
            this.buttonSortPosts.UseVisualStyleBackColor = true;
            this.buttonSortPosts.Click += new System.EventHandler(this.buttonSortPosts_Click);
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 508);
            this.Controls.Add(this.panelPosts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPosts";
            this.Text = "Events";
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButtonSortByComments;
        private System.Windows.Forms.RadioButton radioButtonSortByLikes;
        private System.Windows.Forms.RadioButton radioButtonSortByDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSortPosts;
    }
}