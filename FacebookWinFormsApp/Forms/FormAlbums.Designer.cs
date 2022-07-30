
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
            this.listBoxAlbumsList = new System.Windows.Forms.ListBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.pictureBoxAlbumsCoverPhoto = new System.Windows.Forms.PictureBox();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlbums
            // 
            this.panelAlbums.Controls.Add(this.listBoxAlbumsList);
            this.panelAlbums.Controls.Add(this.pictureBoxAlbumsCoverPhoto);
            this.panelAlbums.Controls.Add(this.buttonFetchAlbums);
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(1481, 945);
            this.panelAlbums.TabIndex = 0;
            this.panelAlbums.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAlbums_Paint);
            // 
            // listBoxAlbumsList
            // 
            this.listBoxAlbumsList.FormattingEnabled = true;
            this.listBoxAlbumsList.ItemHeight = 25;
            this.listBoxAlbumsList.Location = new System.Drawing.Point(107, 44);
            this.listBoxAlbumsList.Name = "listBoxAlbumsList";
            this.listBoxAlbumsList.Size = new System.Drawing.Size(507, 454);
            this.listBoxAlbumsList.TabIndex = 3;
            this.listBoxAlbumsList.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbumsList_SelectedIndexChanged);
            this.listBoxAlbumsList.SelectedValueChanged += new System.EventHandler(this.listBoxAlbumsList_SelectedValueChanged);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(107, 552);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchAlbums.TabIndex = 0;
            this.buttonFetchAlbums.Text = "Fetch albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // pictureBoxAlbumsCoverPhoto
            // 
            this.pictureBoxAlbumsCoverPhoto.Location = new System.Drawing.Point(769, 44);
            this.pictureBoxAlbumsCoverPhoto.Name = "pictureBoxAlbumsCoverPhoto";
            this.pictureBoxAlbumsCoverPhoto.Size = new System.Drawing.Size(481, 454);
            this.pictureBoxAlbumsCoverPhoto.TabIndex = 2;
            this.pictureBoxAlbumsCoverPhoto.TabStop = false;
            this.pictureBoxAlbumsCoverPhoto.Click += new System.EventHandler(this.pictureBoxAlbumsCoverPhoto_Click);
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
            this.panelAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsCoverPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbumsCoverPhoto;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.ListBox listBoxAlbumsList;
    }
}