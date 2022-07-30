
namespace BasicFacebookFeatures.Forms
{
    partial class FormPages
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
            this.panelPages = new System.Windows.Forms.Panel();
            this.listBoxPagesList = new System.Windows.Forms.ListBox();
            this.pictureBoxPagesCoverPhoto = new System.Windows.Forms.PictureBox();
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPagesCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPages
            // 
            this.panelPages.Controls.Add(this.listBoxPagesList);
            this.panelPages.Controls.Add(this.pictureBoxPagesCoverPhoto);
            this.panelPages.Controls.Add(this.buttonFetchPages);
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPages.Location = new System.Drawing.Point(0, 0);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(1481, 945);
            this.panelPages.TabIndex = 2;
            // 
            // listBoxPagesList
            // 
            this.listBoxPagesList.FormattingEnabled = true;
            this.listBoxPagesList.ItemHeight = 25;
            this.listBoxPagesList.Location = new System.Drawing.Point(107, 44);
            this.listBoxPagesList.Name = "listBoxPagesList";
            this.listBoxPagesList.Size = new System.Drawing.Size(507, 454);
            this.listBoxPagesList.TabIndex = 3;
            this.listBoxPagesList.SelectedValueChanged += new System.EventHandler(this.listBoxPagesList_SelectedValueChanged);
            // 
            // pictureBoxPagesCoverPhoto
            // 
            this.pictureBoxPagesCoverPhoto.Location = new System.Drawing.Point(769, 44);
            this.pictureBoxPagesCoverPhoto.Name = "pictureBoxPagesCoverPhoto";
            this.pictureBoxPagesCoverPhoto.Size = new System.Drawing.Size(481, 454);
            this.pictureBoxPagesCoverPhoto.TabIndex = 2;
            this.pictureBoxPagesCoverPhoto.TabStop = false;
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.Location = new System.Drawing.Point(107, 551);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchPages.TabIndex = 0;
            this.buttonFetchPages.Text = "Fetch pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // FormPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 945);
            this.Controls.Add(this.panelPages);
            this.MaximumSize = new System.Drawing.Size(1507, 1016);
            this.MinimumSize = new System.Drawing.Size(1507, 1016);
            this.Name = "FormPages";
            this.Text = "Pages";
            this.panelPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPagesCoverPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.ListBox listBoxPagesList;
        private System.Windows.Forms.PictureBox pictureBoxPagesCoverPhoto;
        private System.Windows.Forms.Button buttonFetchPages;
    }
}