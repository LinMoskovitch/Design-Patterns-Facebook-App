using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWinFormsEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormCollage : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormCollage(FacebookUserManager i_FacebookUserManager)
        {
            InitializeComponent();
            r_FacebookUserManager = i_FacebookUserManager;
        }

        private void buttonFetchPhotos_Click(object i_Sender, EventArgs i_E)
        {
            fetchAllPhotos();
        }

        private void fetchAllPhotos()
        {
            listBoxPhotosList.Items.Clear();
            foreach (Album userAlbum in r_FacebookUserManager.LoggedInUserAlbums)
            {
                foreach(Photo userPhoto in userAlbum.Photos)
                {
                    listBoxPhotosList.Items.Add(userPhoto);
                }
            }

            if (listBoxPhotosList.Items.Count == 0)
            {
                MessageBox.Show("No photos to fetch.");
            }
        }

        private void buttonMakeCollage_Click(object i_Sender, EventArgs i_E)
        {
            int pictureIndex = 0;
            int selectedPhotosCount = 0;
            List<Photo> photosToCollage = new List<Photo>();
            PictureBox currentPictureBox;

            clearPreviousCollage();
            if(listBoxPhotosList.SelectedItems.Count <= 4)
            {
                foreach(Photo currentSelectedPhoto in listBoxPhotosList.SelectedItems)
                {
                    photosToCollage.Add(currentSelectedPhoto);
                    selectedPhotosCount = photosToCollage.Count;
                }

                foreach(Control currentControl in panelCollageContainer.Controls)
                {
                    if(pictureIndex < selectedPhotosCount && currentControl.GetType() == typeof(PictureBox))
                    {
                        currentPictureBox = (PictureBox)currentControl;
                        currentPictureBox.Visible = true;
                        currentPictureBox.LoadAsync(photosToCollage.ElementAt(pictureIndex)?.PictureNormalURL);
                        pictureIndex++;
                    }
                }
            }
            else
            {
                MessageBox.Show("You have selected more than 4 photos");
            }
        }

        private void clearPreviousCollage()
        {
            PictureBox currentPictureBox;

            foreach (Control currentControl in panelCollageContainer.Controls)
            {
                if(currentControl.GetType() == typeof(PictureBox))
                {
                    currentPictureBox = (PictureBox)currentControl;
                    currentPictureBox.Image = null;
                }
            }
        }

        private void listBoxPhotosList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            labelCurrentSelectedPhoto.Visible = true;
            pictureBoxSample.LoadAsync((listBoxPhotosList.SelectedItem as Photo)?.PictureNormalURL);
        }

        private void FormCollage_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelCollage);
        }
    }
}
