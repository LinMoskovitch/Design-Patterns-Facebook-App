
namespace BasicFacebookFeatures.Forms
{
    partial class FormAlbums
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
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.buttonSortAlbums = new System.Windows.Forms.Button();
            this.groupBoxSortingButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonSortByAmountOfPhotos = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByDate = new System.Windows.Forms.RadioButton();
            this.labelCoverPhoto = new System.Windows.Forms.Label();
            this.listBoxAlbumsList = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbumsCoverPhoto = new System.Windows.Forms.PictureBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.labelDateCreated = new System.Windows.Forms.Label();
            this.textBoxDateCreated = new System.Windows.Forms.TextBox();
            this.panelAlbums.SuspendLayout();
            this.groupBoxSortingButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlbums
            // 
            this.panelAlbums.Controls.Add(this.textBoxDateCreated);
            this.panelAlbums.Controls.Add(this.labelDateCreated);
            this.panelAlbums.Controls.Add(this.buttonSortAlbums);
            this.panelAlbums.Controls.Add(this.groupBoxSortingButtons);
            this.panelAlbums.Controls.Add(this.labelCoverPhoto);
            this.panelAlbums.Controls.Add(this.listBoxAlbumsList);
            this.panelAlbums.Controls.Add(this.pictureBoxAlbumsCoverPhoto);
            this.panelAlbums.Controls.Add(this.buttonFetchAlbums);
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(993, 620);
            this.panelAlbums.TabIndex = 0;
            // 
            // buttonSortAlbums
            // 
            this.buttonSortAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortAlbums.Location = new System.Drawing.Point(415, 181);
            this.buttonSortAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSortAlbums.Name = "buttonSortAlbums";
            this.buttonSortAlbums.Size = new System.Drawing.Size(150, 51);
            this.buttonSortAlbums.TabIndex = 6;
            this.buttonSortAlbums.Text = "Sort albums";
            this.buttonSortAlbums.UseVisualStyleBackColor = true;
            this.buttonSortAlbums.Click += new System.EventHandler(this.buttonSortAlbums_Click);
            // 
            // groupBoxSortingButtons
            // 
            this.groupBoxSortingButtons.Controls.Add(this.radioButtonSortByAmountOfPhotos);
            this.groupBoxSortingButtons.Controls.Add(this.radioButtonSortByDate);
            this.groupBoxSortingButtons.Location = new System.Drawing.Point(415, 95);
            this.groupBoxSortingButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSortingButtons.Name = "groupBoxSortingButtons";
            this.groupBoxSortingButtons.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxSortingButtons.Size = new System.Drawing.Size(150, 82);
            this.groupBoxSortingButtons.TabIndex = 5;
            this.groupBoxSortingButtons.TabStop = false;
            this.groupBoxSortingButtons.Text = "Sort albums by";
            // 
            // radioButtonSortByAmountOfPhotos
            // 
            this.radioButtonSortByAmountOfPhotos.AutoSize = true;
            this.radioButtonSortByAmountOfPhotos.Location = new System.Drawing.Point(5, 49);
            this.radioButtonSortByAmountOfPhotos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSortByAmountOfPhotos.Name = "radioButtonSortByAmountOfPhotos";
            this.radioButtonSortByAmountOfPhotos.Size = new System.Drawing.Size(131, 20);
            this.radioButtonSortByAmountOfPhotos.TabIndex = 1;
            this.radioButtonSortByAmountOfPhotos.TabStop = true;
            this.radioButtonSortByAmountOfPhotos.Text = "Amount of photos";
            this.radioButtonSortByAmountOfPhotos.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortByDate
            // 
            this.radioButtonSortByDate.AutoSize = true;
            this.radioButtonSortByDate.Location = new System.Drawing.Point(5, 27);
            this.radioButtonSortByDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSortByDate.Name = "radioButtonSortByDate";
            this.radioButtonSortByDate.Size = new System.Drawing.Size(106, 20);
            this.radioButtonSortByDate.TabIndex = 0;
            this.radioButtonSortByDate.TabStop = true;
            this.radioButtonSortByDate.Text = "Date created";
            this.radioButtonSortByDate.UseVisualStyleBackColor = true;
            // 
            // labelCoverPhoto
            // 
            this.labelCoverPhoto.AutoSize = true;
            this.labelCoverPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoverPhoto.Location = new System.Drawing.Point(579, 41);
            this.labelCoverPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoverPhoto.Name = "labelCoverPhoto";
            this.labelCoverPhoto.Size = new System.Drawing.Size(209, 26);
            this.labelCoverPhoto.TabIndex = 4;
            this.labelCoverPhoto.Text = "Album\'s cover photo";
            this.labelCoverPhoto.Visible = false;
            // 
            // listBoxAlbumsList
            // 
            this.listBoxAlbumsList.FormattingEnabled = true;
            this.listBoxAlbumsList.ItemHeight = 16;
            this.listBoxAlbumsList.Location = new System.Drawing.Point(73, 95);
            this.listBoxAlbumsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAlbumsList.Name = "listBoxAlbumsList";
            this.listBoxAlbumsList.Size = new System.Drawing.Size(339, 292);
            this.listBoxAlbumsList.TabIndex = 3;
            this.listBoxAlbumsList.SelectedValueChanged += new System.EventHandler(this.listBoxAlbumsList_SelectedValueChanged);
            // 
            // pictureBoxAlbumsCoverPhoto
            // 
            this.pictureBoxAlbumsCoverPhoto.Location = new System.Drawing.Point(583, 95);
            this.pictureBoxAlbumsCoverPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAlbumsCoverPhoto.Name = "pictureBoxAlbumsCoverPhoto";
            this.pictureBoxAlbumsCoverPhoto.Size = new System.Drawing.Size(321, 291);
            this.pictureBoxAlbumsCoverPhoto.TabIndex = 2;
            this.pictureBoxAlbumsCoverPhoto.TabStop = false;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(73, 420);
            this.buttonFetchAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(136, 51);
            this.buttonFetchAlbums.TabIndex = 0;
            this.buttonFetchAlbums.Text = "Fetch albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // labelDateCreated
            // 
            this.labelDateCreated.AutoSize = true;
            this.labelDateCreated.Location = new System.Drawing.Point(584, 420);
            this.labelDateCreated.Name = "labelDateCreated";
            this.labelDateCreated.Size = new System.Drawing.Size(85, 16);
            this.labelDateCreated.TabIndex = 7;
            this.labelDateCreated.Text = "Date created";
            // 
            // textBoxDateCreated
            // 
            this.textBoxDateCreated.Location = new System.Drawing.Point(699, 420);
            this.textBoxDateCreated.Name = "textBoxDateCreated";
            this.textBoxDateCreated.ReadOnly = true;
            this.textBoxDateCreated.Size = new System.Drawing.Size(100, 22);
            this.textBoxDateCreated.TabIndex = 9;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 620);
            this.Controls.Add(this.panelAlbums);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1011, 667);
            this.MinimumSize = new System.Drawing.Size(1011, 667);
            this.Name = "FormAlbums";
            this.Text = "Albums";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            this.groupBoxSortingButtons.ResumeLayout(false);
            this.groupBoxSortingButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCoverPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbumsCoverPhoto;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.ListBox listBoxAlbumsList;
        private System.Windows.Forms.Label labelCoverPhoto;
        private System.Windows.Forms.Button buttonSortAlbums;
        private System.Windows.Forms.GroupBox groupBoxSortingButtons;
        private System.Windows.Forms.RadioButton radioButtonSortByAmountOfPhotos;
        private System.Windows.Forms.RadioButton radioButtonSortByDate;
        private System.Windows.Forms.TextBox textBoxDateCreated;
        private System.Windows.Forms.Label labelDateCreated;
    }
}