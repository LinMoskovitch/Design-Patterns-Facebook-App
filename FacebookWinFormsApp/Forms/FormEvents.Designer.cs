
namespace BasicFacebookFeatures.Forms
{
    partial class FormEvents
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
            this.listBoxEventsList = new System.Windows.Forms.ListBox();
            this.pictureBoxEventsCoverPhoto = new System.Windows.Forms.PictureBox();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.panelAlbums = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsCoverPhoto)).BeginInit();
            this.panelAlbums.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEventsList
            // 
            this.listBoxEventsList.FormattingEnabled = true;
            this.listBoxEventsList.ItemHeight = 25;
            this.listBoxEventsList.Location = new System.Drawing.Point(107, 44);
            this.listBoxEventsList.Name = "listBoxEventsList";
            this.listBoxEventsList.Size = new System.Drawing.Size(507, 454);
            this.listBoxEventsList.TabIndex = 3;
            // 
            // pictureBoxEventsCoverPhoto
            // 
            this.pictureBoxEventsCoverPhoto.Location = new System.Drawing.Point(769, 44);
            this.pictureBoxEventsCoverPhoto.Name = "pictureBoxEventsCoverPhoto";
            this.pictureBoxEventsCoverPhoto.Size = new System.Drawing.Size(481, 454);
            this.pictureBoxEventsCoverPhoto.TabIndex = 2;
            this.pictureBoxEventsCoverPhoto.TabStop = false;
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(107, 551);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchEvents.TabIndex = 0;
            this.buttonFetchEvents.Text = "Fetch events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // panelAlbums
            // 
            this.panelAlbums.Controls.Add(this.listBoxEventsList);
            this.panelAlbums.Controls.Add(this.pictureBoxEventsCoverPhoto);
            this.panelAlbums.Controls.Add(this.buttonFetchEvents);
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(1514, 794);
            this.panelAlbums.TabIndex = 1;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 794);
            this.Controls.Add(this.panelAlbums);
            this.Name = "FormEvents";
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsCoverPhoto)).EndInit();
            this.panelAlbums.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEventsList;
        private System.Windows.Forms.PictureBox pictureBoxEventsCoverPhoto;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Panel panelAlbums;
    }
}