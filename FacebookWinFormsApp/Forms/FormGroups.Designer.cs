
namespace BasicFacebookFeatures.Forms
{
    partial class FormGroups
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
            this.listBoxGroupsList = new System.Windows.Forms.ListBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.pictureBoxGroupsCoverPhoto = new System.Windows.Forms.PictureBox();
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroups
            // 
            this.panelGroups.Controls.Add(this.listBoxGroupsList);
            this.panelGroups.Controls.Add(this.pictureBoxGroupsCoverPhoto);
            this.panelGroups.Controls.Add(this.buttonFetchGroups);
            this.panelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroups.Location = new System.Drawing.Point(0, 0);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(1466, 809);
            this.panelGroups.TabIndex = 1;
            // 
            // listBoxGroupsList
            // 
            this.listBoxGroupsList.FormattingEnabled = true;
            this.listBoxGroupsList.ItemHeight = 25;
            this.listBoxGroupsList.Location = new System.Drawing.Point(107, 44);
            this.listBoxGroupsList.Name = "listBoxGroupsList";
            this.listBoxGroupsList.Size = new System.Drawing.Size(507, 454);
            this.listBoxGroupsList.TabIndex = 3;
            this.listBoxGroupsList.SelectedValueChanged += new System.EventHandler(this.listBoxGroupsList_SelectedValueChanged);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Location = new System.Drawing.Point(107, 551);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(204, 80);
            this.buttonFetchGroups.TabIndex = 0;
            this.buttonFetchGroups.Text = "Fetch groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // pictureBoxGroupsCoverPhoto
            // 
            this.pictureBoxGroupsCoverPhoto.Location = new System.Drawing.Point(769, 44);
            this.pictureBoxGroupsCoverPhoto.Name = "pictureBoxGroupsCoverPhoto";
            this.pictureBoxGroupsCoverPhoto.Size = new System.Drawing.Size(481, 454);
            this.pictureBoxGroupsCoverPhoto.TabIndex = 2;
            this.pictureBoxGroupsCoverPhoto.TabStop = false;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 809);
            this.Controls.Add(this.panelGroups);
            this.Name = "FormGroups";
            this.Text = "Groups";
            this.panelGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsCoverPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.ListBox listBoxGroupsList;
        private System.Windows.Forms.PictureBox pictureBoxGroupsCoverPhoto;
        private System.Windows.Forms.Button buttonFetchGroups;
    }
}