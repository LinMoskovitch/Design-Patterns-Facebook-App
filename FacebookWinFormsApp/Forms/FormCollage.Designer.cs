
namespace BasicFacebookFeatures.Forms
{
    partial class FormCollage
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
            this.panelCollage = new System.Windows.Forms.Panel();
            this.labelCurrentSelectedPhoto = new System.Windows.Forms.Label();
            this.buttonMakeCollage = new System.Windows.Forms.Button();
            this.panelCollageContainer = new System.Windows.Forms.Panel();
            this.labelCollageInstructions = new System.Windows.Forms.Label();
            this.listBoxPhotosList = new System.Windows.Forms.ListBox();
            this.buttonFetchPhotos = new System.Windows.Forms.Button();
            this.pictureBoxSample = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto4 = new System.Windows.Forms.PictureBox();
            this.panelCollage.SuspendLayout();
            this.panelCollageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCollage
            // 
            this.panelCollage.Controls.Add(this.labelCurrentSelectedPhoto);
            this.panelCollage.Controls.Add(this.pictureBoxSample);
            this.panelCollage.Controls.Add(this.buttonMakeCollage);
            this.panelCollage.Controls.Add(this.panelCollageContainer);
            this.panelCollage.Controls.Add(this.labelCollageInstructions);
            this.panelCollage.Controls.Add(this.listBoxPhotosList);
            this.panelCollage.Controls.Add(this.buttonFetchPhotos);
            this.panelCollage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCollage.Location = new System.Drawing.Point(0, 0);
            this.panelCollage.Name = "panelCollage";
            this.panelCollage.Size = new System.Drawing.Size(1481, 945);
            this.panelCollage.TabIndex = 1;
            // 
            // labelCurrentSelectedPhoto
            // 
            this.labelCurrentSelectedPhoto.AutoSize = true;
            this.labelCurrentSelectedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSelectedPhoto.Location = new System.Drawing.Point(326, 359);
            this.labelCurrentSelectedPhoto.Name = "labelCurrentSelectedPhoto";
            this.labelCurrentSelectedPhoto.Size = new System.Drawing.Size(242, 39);
            this.labelCurrentSelectedPhoto.TabIndex = 8;
            this.labelCurrentSelectedPhoto.Text = "selected photo";
            this.labelCurrentSelectedPhoto.Visible = false;
            // 
            // buttonMakeCollage
            // 
            this.buttonMakeCollage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeCollage.Location = new System.Drawing.Point(186, 686);
            this.buttonMakeCollage.Name = "buttonMakeCollage";
            this.buttonMakeCollage.Size = new System.Drawing.Size(130, 80);
            this.buttonMakeCollage.TabIndex = 6;
            this.buttonMakeCollage.Text = "Make collage";
            this.buttonMakeCollage.UseVisualStyleBackColor = true;
            this.buttonMakeCollage.Click += new System.EventHandler(this.buttonMakeCollage_Click);
            // 
            // panelCollageContainer
            // 
            this.panelCollageContainer.Controls.Add(this.pictureBoxPhoto1);
            this.panelCollageContainer.Controls.Add(this.pictureBoxPhoto2);
            this.panelCollageContainer.Controls.Add(this.pictureBoxPhoto3);
            this.panelCollageContainer.Controls.Add(this.pictureBoxPhoto4);
            this.panelCollageContainer.Location = new System.Drawing.Point(699, 161);
            this.panelCollageContainer.Name = "panelCollageContainer";
            this.panelCollageContainer.Size = new System.Drawing.Size(500, 500);
            this.panelCollageContainer.TabIndex = 5;
            // 
            // labelCollageInstructions
            // 
            this.labelCollageInstructions.AutoSize = true;
            this.labelCollageInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollageInstructions.Location = new System.Drawing.Point(23, 73);
            this.labelCollageInstructions.Name = "labelCollageInstructions";
            this.labelCollageInstructions.Size = new System.Drawing.Size(642, 39);
            this.labelCollageInstructions.TabIndex = 4;
            this.labelCollageInstructions.Text = "Choose up to 4 photos to make a collage";
            // 
            // listBoxPhotosList
            // 
            this.listBoxPhotosList.FormattingEnabled = true;
            this.listBoxPhotosList.ItemHeight = 25;
            this.listBoxPhotosList.Location = new System.Drawing.Point(30, 157);
            this.listBoxPhotosList.Name = "listBoxPhotosList";
            this.listBoxPhotosList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPhotosList.Size = new System.Drawing.Size(286, 504);
            this.listBoxPhotosList.TabIndex = 3;
            this.listBoxPhotosList.SelectedValueChanged += new System.EventHandler(this.listBoxPhotosList_SelectedValueChanged);
            // 
            // buttonFetchPhotos
            // 
            this.buttonFetchPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchPhotos.Location = new System.Drawing.Point(30, 686);
            this.buttonFetchPhotos.Name = "buttonFetchPhotos";
            this.buttonFetchPhotos.Size = new System.Drawing.Size(150, 80);
            this.buttonFetchPhotos.TabIndex = 0;
            this.buttonFetchPhotos.Text = "Fetch all photos";
            this.buttonFetchPhotos.UseVisualStyleBackColor = true;
            this.buttonFetchPhotos.Click += new System.EventHandler(this.buttonFetchPhotos_Click);
            // 
            // pictureBoxSample
            // 
            this.pictureBoxSample.Location = new System.Drawing.Point(333, 435);
            this.pictureBoxSample.Name = "pictureBoxSample";
            this.pictureBoxSample.Size = new System.Drawing.Size(231, 226);
            this.pictureBoxSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSample.TabIndex = 7;
            this.pictureBoxSample.TabStop = false;
            // 
            // pictureBoxPhoto1
            // 
            this.pictureBoxPhoto1.Location = new System.Drawing.Point(250, 250);
            this.pictureBoxPhoto1.Name = "pictureBoxPhoto1";
            this.pictureBoxPhoto1.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto1.TabIndex = 3;
            this.pictureBoxPhoto1.TabStop = false;
            this.pictureBoxPhoto1.Visible = false;
            // 
            // pictureBoxPhoto2
            // 
            this.pictureBoxPhoto2.Location = new System.Drawing.Point(0, 250);
            this.pictureBoxPhoto2.Name = "pictureBoxPhoto2";
            this.pictureBoxPhoto2.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto2.TabIndex = 2;
            this.pictureBoxPhoto2.TabStop = false;
            this.pictureBoxPhoto2.Visible = false;
            // 
            // pictureBoxPhoto3
            // 
            this.pictureBoxPhoto3.Location = new System.Drawing.Point(250, 0);
            this.pictureBoxPhoto3.Name = "pictureBoxPhoto3";
            this.pictureBoxPhoto3.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPhoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto3.TabIndex = 1;
            this.pictureBoxPhoto3.TabStop = false;
            this.pictureBoxPhoto3.Visible = false;
            // 
            // pictureBoxPhoto4
            // 
            this.pictureBoxPhoto4.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPhoto4.Name = "pictureBoxPhoto4";
            this.pictureBoxPhoto4.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPhoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto4.TabIndex = 0;
            this.pictureBoxPhoto4.TabStop = false;
            this.pictureBoxPhoto4.Visible = false;
            // 
            // FormCollage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 945);
            this.Controls.Add(this.panelCollage);
            this.MaximumSize = new System.Drawing.Size(1507, 1016);
            this.MinimumSize = new System.Drawing.Size(1507, 1016);
            this.Name = "FormCollage";
            this.Text = "Collage";
            this.Load += new System.EventHandler(this.FormCollage_Load);
            this.panelCollage.ResumeLayout(false);
            this.panelCollage.PerformLayout();
            this.panelCollageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCollage;
        private System.Windows.Forms.Button buttonMakeCollage;
        private System.Windows.Forms.Panel panelCollageContainer;
        private System.Windows.Forms.PictureBox pictureBoxPhoto1;
        private System.Windows.Forms.PictureBox pictureBoxPhoto2;
        private System.Windows.Forms.PictureBox pictureBoxPhoto3;
        private System.Windows.Forms.PictureBox pictureBoxPhoto4;
        private System.Windows.Forms.Label labelCollageInstructions;
        private System.Windows.Forms.ListBox listBoxPhotosList;
        private System.Windows.Forms.Button buttonFetchPhotos;
        private System.Windows.Forms.PictureBox pictureBoxSample;
        private System.Windows.Forms.Label labelCurrentSelectedPhoto;
    }
}