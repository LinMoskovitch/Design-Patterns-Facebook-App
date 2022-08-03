
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
            this.labelCoverPhoto = new System.Windows.Forms.Label();
            this.listBoxAlbumsList = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbumsCoverPhoto = new System.Windows.Forms.PictureBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.groupBoxSortingButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonSortByDate = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByAmountOfPhotos = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByLikes = new System.Windows.Forms.RadioButton();
            this.buttonSortAlbums = new System.Windows.Forms.Button();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCoverPhoto)).BeginInit();
            this.groupBoxSortingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlbums
            // 
            this.panelAlbums.Controls.Add(this.buttonSortAlbums);
            this.panelAlbums.Controls.Add(this.groupBoxSortingButtons);
            this.panelAlbums.Controls.Add(this.labelCoverPhoto);
            this.panelAlbums.Controls.Add(this.listBoxAlbumsList);
            this.panelAlbums.Controls.Add(this.pictureBoxAlbumsCoverPhoto);
            this.panelAlbums.Controls.Add(this.buttonFetchAlbums);
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(1481, 945);
            this.panelAlbums.TabIndex = 0;
            // 
            // labelCoverPhoto
            // 
            this.labelCoverPhoto.AutoSize = true;
            this.labelCoverPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoverPhoto.Location = new System.Drawing.Point(868, 64);
            this.labelCoverPhoto.Name = "labelCoverPhoto";
            this.labelCoverPhoto.Size = new System.Drawing.Size(331, 39);
            this.labelCoverPhoto.TabIndex = 4;
            this.labelCoverPhoto.Text = "Album\'s cover photo";
            this.labelCoverPhoto.Visible = false;
            // 
            // listBoxAlbumsList
            // 
            this.listBoxAlbumsList.FormattingEnabled = true;
            this.listBoxAlbumsList.ItemHeight = 25;
            this.listBoxAlbumsList.Location = new System.Drawing.Point(110, 149);
            this.listBoxAlbumsList.Name = "listBoxAlbumsList";
            this.listBoxAlbumsList.Size = new System.Drawing.Size(507, 454);
            this.listBoxAlbumsList.TabIndex = 3;
            this.listBoxAlbumsList.SelectedValueChanged += new System.EventHandler(this.listBoxAlbumsList_SelectedValueChanged);
            // 
            // pictureBoxAlbumsCoverPhoto
            // 
            this.pictureBoxAlbumsCoverPhoto.Location = new System.Drawing.Point(875, 149);
            this.pictureBoxAlbumsCoverPhoto.Name = "pictureBoxAlbumsCoverPhoto";
            this.pictureBoxAlbumsCoverPhoto.Size = new System.Drawing.Size(481, 454);
            this.pictureBoxAlbumsCoverPhoto.TabIndex = 2;
            this.pictureBoxAlbumsCoverPhoto.TabStop = false;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(110, 657);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchAlbums.TabIndex = 0;
            this.buttonFetchAlbums.Text = "Fetch albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // groupBoxSortingButtons
            // 
            this.groupBoxSortingButtons.Controls.Add(this.radioButtonSortByLikes);
            this.groupBoxSortingButtons.Controls.Add(this.radioButtonSortByAmountOfPhotos);
            this.groupBoxSortingButtons.Controls.Add(this.radioButtonSortByDate);
            this.groupBoxSortingButtons.Location = new System.Drawing.Point(623, 149);
            this.groupBoxSortingButtons.Name = "groupBoxSortingButtons";
            this.groupBoxSortingButtons.Size = new System.Drawing.Size(225, 175);
            this.groupBoxSortingButtons.TabIndex = 5;
            this.groupBoxSortingButtons.TabStop = false;
            this.groupBoxSortingButtons.Text = "Sort albums by";
            // 
            // radioButtonSortByDate
            // 
            this.radioButtonSortByDate.AutoSize = true;
            this.radioButtonSortByDate.Location = new System.Drawing.Point(7, 42);
            this.radioButtonSortByDate.Name = "radioButtonSortByDate";
            this.radioButtonSortByDate.Size = new System.Drawing.Size(166, 29);
            this.radioButtonSortByDate.TabIndex = 0;
            this.radioButtonSortByDate.TabStop = true;
            this.radioButtonSortByDate.Text = "Date created";
            this.radioButtonSortByDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortByAmountOfPhotos
            // 
            this.radioButtonSortByAmountOfPhotos.AutoSize = true;
            this.radioButtonSortByAmountOfPhotos.Location = new System.Drawing.Point(7, 77);
            this.radioButtonSortByAmountOfPhotos.Name = "radioButtonSortByAmountOfPhotos";
            this.radioButtonSortByAmountOfPhotos.Size = new System.Drawing.Size(211, 29);
            this.radioButtonSortByAmountOfPhotos.TabIndex = 1;
            this.radioButtonSortByAmountOfPhotos.TabStop = true;
            this.radioButtonSortByAmountOfPhotos.Text = "Amount of photos";
            this.radioButtonSortByAmountOfPhotos.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortByLikes
            // 
            this.radioButtonSortByLikes.AutoSize = true;
            this.radioButtonSortByLikes.Location = new System.Drawing.Point(7, 112);
            this.radioButtonSortByLikes.Name = "radioButtonSortByLikes";
            this.radioButtonSortByLikes.Size = new System.Drawing.Size(190, 29);
            this.radioButtonSortByLikes.TabIndex = 2;
            this.radioButtonSortByLikes.TabStop = true;
            this.radioButtonSortByLikes.Text = "Amount of likes";
            this.radioButtonSortByLikes.UseVisualStyleBackColor = true;
            // 
            // buttonSortAlbums
            // 
            this.buttonSortAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSortAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortAlbums.Location = new System.Drawing.Point(623, 344);
            this.buttonSortAlbums.Name = "buttonSortAlbums";
            this.buttonSortAlbums.Size = new System.Drawing.Size(225, 80);
            this.buttonSortAlbums.TabIndex = 6;
            this.buttonSortAlbums.Text = "Sort albums";
            this.buttonSortAlbums.UseVisualStyleBackColor = true;
            this.buttonSortAlbums.Click += new System.EventHandler(this.buttonSortAlbums_Click);
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 945);
            this.Controls.Add(this.panelAlbums);
            this.MaximumSize = new System.Drawing.Size(1507, 1016);
            this.MinimumSize = new System.Drawing.Size(1507, 1016);
            this.Name = "FormAlbums";
            this.Text = "Albums";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCoverPhoto)).EndInit();
            this.groupBoxSortingButtons.ResumeLayout(false);
            this.groupBoxSortingButtons.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButtonSortByLikes;
        private System.Windows.Forms.RadioButton radioButtonSortByAmountOfPhotos;
        private System.Windows.Forms.RadioButton radioButtonSortByDate;
    }
}