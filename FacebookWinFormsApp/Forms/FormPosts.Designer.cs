
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
            this.listBoxCommentsList = new System.Windows.Forms.ListBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxPostPhotoDisplay = new System.Windows.Forms.PictureBox();
            this.buttonPostNewStatus = new System.Windows.Forms.Button();
            this.radioButtonSortByComments = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByLikes = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByDate = new System.Windows.Forms.RadioButton();
            this.buttonSortPosts = new System.Windows.Forms.Button();
            this.groupBoxRadioButtonsContainer = new System.Windows.Forms.GroupBox();
            this.panelPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoDisplay)).BeginInit();
            this.groupBoxRadioButtonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPostsList
            // 
            this.listBoxPostsList.FormattingEnabled = true;
            this.listBoxPostsList.ItemHeight = 25;
            this.listBoxPostsList.Location = new System.Drawing.Point(106, 44);
            this.listBoxPostsList.Name = "listBoxPostsList";
            this.listBoxPostsList.Size = new System.Drawing.Size(506, 204);
            this.listBoxPostsList.TabIndex = 3;
            this.listBoxPostsList.SelectedValueChanged += new System.EventHandler(this.listBoxEventsList_SelectedValueChanged);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchPosts.Location = new System.Drawing.Point(106, 552);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchPosts.TabIndex = 0;
            this.buttonFetchPosts.Text = "Fetch posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // panelPosts
            // 
            this.panelPosts.Controls.Add(this.groupBoxRadioButtonsContainer);
            this.panelPosts.Controls.Add(this.listBoxCommentsList);
            this.panelPosts.Controls.Add(this.textBoxStatus);
            this.panelPosts.Controls.Add(this.pictureBoxPostPhotoDisplay);
            this.panelPosts.Controls.Add(this.buttonPostNewStatus);
            this.panelPosts.Controls.Add(this.listBoxPostsList);
            this.panelPosts.Controls.Add(this.buttonFetchPosts);
            this.panelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPosts.Location = new System.Drawing.Point(0, 0);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(1481, 945);
            this.panelPosts.TabIndex = 1;
            // 
            // listBoxCommentsList
            // 
            this.listBoxCommentsList.FormattingEnabled = true;
            this.listBoxCommentsList.ItemHeight = 25;
            this.listBoxCommentsList.Location = new System.Drawing.Point(106, 294);
            this.listBoxCommentsList.Name = "listBoxCommentsList";
            this.listBoxCommentsList.Size = new System.Drawing.Size(506, 204);
            this.listBoxCommentsList.TabIndex = 8;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(106, 655);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(527, 101);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // pictureBoxPostPhotoDisplay
            // 
            this.pictureBoxPostPhotoDisplay.Location = new System.Drawing.Point(878, 44);
            this.pictureBoxPostPhotoDisplay.Name = "pictureBoxPostPhotoDisplay";
            this.pictureBoxPostPhotoDisplay.Size = new System.Drawing.Size(482, 455);
            this.pictureBoxPostPhotoDisplay.TabIndex = 6;
            this.pictureBoxPostPhotoDisplay.TabStop = false;
            // 
            // buttonPostNewStatus
            // 
            this.buttonPostNewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostNewStatus.Location = new System.Drawing.Point(656, 701);
            this.buttonPostNewStatus.Name = "buttonPostNewStatus";
            this.buttonPostNewStatus.Size = new System.Drawing.Size(204, 55);
            this.buttonPostNewStatus.TabIndex = 5;
            this.buttonPostNewStatus.Text = "Post a new status";
            this.buttonPostNewStatus.UseVisualStyleBackColor = true;
            this.buttonPostNewStatus.Click += new System.EventHandler(this.buttonAddNewPost_Click);
            // 
            // radioButtonSortByComments
            // 
            this.radioButtonSortByComments.AutoSize = true;
            this.radioButtonSortByComments.Location = new System.Drawing.Point(9, 114);
            this.radioButtonSortByComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSortByComments.Name = "radioButtonSortByComments";
            this.radioButtonSortByComments.Size = new System.Drawing.Size(211, 29);
            this.radioButtonSortByComments.TabIndex = 11;
            this.radioButtonSortByComments.Text = "Most Commented";
            this.radioButtonSortByComments.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortByLikes
            // 
            this.radioButtonSortByLikes.AutoSize = true;
            this.radioButtonSortByLikes.Location = new System.Drawing.Point(9, 73);
            this.radioButtonSortByLikes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSortByLikes.Name = "radioButtonSortByLikes";
            this.radioButtonSortByLikes.Size = new System.Drawing.Size(148, 29);
            this.radioButtonSortByLikes.TabIndex = 10;
            this.radioButtonSortByLikes.Text = "Most Liked";
            this.radioButtonSortByLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSortByLikes.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortByDate
            // 
            this.radioButtonSortByDate.AutoSize = true;
            this.radioButtonSortByDate.Checked = true;
            this.radioButtonSortByDate.Location = new System.Drawing.Point(9, 33);
            this.radioButtonSortByDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSortByDate.Name = "radioButtonSortByDate";
            this.radioButtonSortByDate.Size = new System.Drawing.Size(247, 29);
            this.radioButtonSortByDate.TabIndex = 9;
            this.radioButtonSortByDate.TabStop = true;
            this.radioButtonSortByDate.Text = "Date posted (Default)";
            this.radioButtonSortByDate.UseVisualStyleBackColor = true;
            // 
            // buttonSortPosts
            // 
            this.buttonSortPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortPosts.Location = new System.Drawing.Point(75, 195);
            this.buttonSortPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSortPosts.Name = "buttonSortPosts";
            this.buttonSortPosts.Size = new System.Drawing.Size(163, 48);
            this.buttonSortPosts.TabIndex = 12;
            this.buttonSortPosts.Text = "Sort posts";
            this.buttonSortPosts.UseVisualStyleBackColor = true;
            this.buttonSortPosts.Click += new System.EventHandler(this.buttonSortPosts_Click);
            // 
            // groupBoxRadioButtonsContainer
            // 
            this.groupBoxRadioButtonsContainer.Controls.Add(this.buttonSortPosts);
            this.groupBoxRadioButtonsContainer.Controls.Add(this.radioButtonSortByDate);
            this.groupBoxRadioButtonsContainer.Controls.Add(this.radioButtonSortByLikes);
            this.groupBoxRadioButtonsContainer.Controls.Add(this.radioButtonSortByComments);
            this.groupBoxRadioButtonsContainer.Location = new System.Drawing.Point(623, 44);
            this.groupBoxRadioButtonsContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRadioButtonsContainer.Name = "groupBoxRadioButtonsContainer";
            this.groupBoxRadioButtonsContainer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxRadioButtonsContainer.Size = new System.Drawing.Size(248, 272);
            this.groupBoxRadioButtonsContainer.TabIndex = 13;
            this.groupBoxRadioButtonsContainer.TabStop = false;
            this.groupBoxRadioButtonsContainer.Text = "Sort posts by";
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 945);
            this.Controls.Add(this.panelPosts);
            this.MaximumSize = new System.Drawing.Size(1507, 1016);
            this.MinimumSize = new System.Drawing.Size(1507, 1016);
            this.Name = "FormPosts";
            this.Text = "Posts";
            this.Load += new System.EventHandler(this.FormPosts_Load);
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoDisplay)).EndInit();
            this.groupBoxRadioButtonsContainer.ResumeLayout(false);
            this.groupBoxRadioButtonsContainer.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxRadioButtonsContainer;
        private System.Windows.Forms.Button buttonSortPosts;
        private System.Windows.Forms.RadioButton radioButtonSortByDate;
        private System.Windows.Forms.RadioButton radioButtonSortByLikes;
        private System.Windows.Forms.RadioButton radioButtonSortByComments;
    }
}