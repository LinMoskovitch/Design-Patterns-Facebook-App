namespace BasicFacebookFeatures.Forms
{
    public partial class FormGroups
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
            this.panelGroups = new System.Windows.Forms.Panel();
            this.labelCoverPhoto = new System.Windows.Forms.Label();
            this.listBoxGroupsList = new System.Windows.Forms.ListBox();
            this.pictureBoxGroupsCoverPhoto = new System.Windows.Forms.PictureBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.labelCoverPhoto);
            this.panelGroups.Controls.Add(this.listBoxGroupsList);
            this.panelGroups.Controls.Add(this.pictureBoxGroupsCoverPhoto);
            this.panelGroups.Controls.Add(this.buttonFetchGroups);
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(0, 0);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(1481, 945);
            this.panelGroups.TabIndex = 1;
            // 
            // labelCoverPhoto
            // 
            this.labelCoverPhoto.AutoSize = true;
            this.labelCoverPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoverPhoto.Location = new System.Drawing.Point(762, 70);
            this.labelCoverPhoto.Name = "labelCoverPhoto";
            this.labelCoverPhoto.Size = new System.Drawing.Size(328, 39);
            this.labelCoverPhoto.TabIndex = 5;
            this.labelCoverPhoto.Text = "Group\'s cover photo";
            this.labelCoverPhoto.Visible = false;
            // 
            // listBoxGroupsList
            // 
            this.listBoxGroupsList.FormattingEnabled = true;
            this.listBoxGroupsList.ItemHeight = 25;
            this.listBoxGroupsList.Location = new System.Drawing.Point(107, 153);
            this.listBoxGroupsList.Name = "listBoxGroupsList";
            this.listBoxGroupsList.Size = new System.Drawing.Size(507, 454);
            this.listBoxGroupsList.TabIndex = 3;
            this.listBoxGroupsList.SelectedValueChanged += new System.EventHandler(this.listBoxGroupsList_SelectedValueChanged);
            // 
            // pictureBoxGroupsCoverPhoto
            // 
            this.pictureBoxGroupsCoverPhoto.Location = new System.Drawing.Point(769, 153);
            this.pictureBoxGroupsCoverPhoto.Name = "pictureBoxGroupsCoverPhoto";
            this.pictureBoxGroupsCoverPhoto.Size = new System.Drawing.Size(481, 454);
            this.pictureBoxGroupsCoverPhoto.TabIndex = 2;
            this.pictureBoxGroupsCoverPhoto.TabStop = false;
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchGroups.Location = new System.Drawing.Point(107, 660);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchGroups.TabIndex = 0;
            this.buttonFetchGroups.Text = "Fetch groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 945);
            this.Controls.Add(this.panelGroups);
            this.MaximumSize = new System.Drawing.Size(1507, 1016);
            this.MinimumSize = new System.Drawing.Size(1507, 1016);
            this.Name = "FormGroups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.FormGroups_Load);
            this.panelGroups.ResumeLayout(false);
            this.panelGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsCoverPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.ListBox listBoxGroupsList;
        private System.Windows.Forms.PictureBox pictureBoxGroupsCoverPhoto;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Label labelCoverPhoto;
    }
}