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
    public partial class FormFeature1 : Form
    {
        public FormCollage(FacebookUserManager i_FacebookUserManager)
        {
            InitializeComponent();
        }

        private void buttonFetchPhotos_Click(object i_Sender, EventArgs e)
        {
            fetchAllPhotos();
        }

        private void fetchAllPhotos()
        {
            listBoxPhotosList.Items.Clear();
            foreach(Album userAlbum in r_LoggedInUser.Albums)
            {
                foreach(Photo userPhoto in userAlbum.Photos)
                {
                    listBoxPhotosList.Items.Add(userPhoto);
                }
            }

            if(listBoxPhotosList.Items.Count == 0)
            {
                MessageBox.Show("No photos to fetch.");
            }
        }

        private void buttonMakeCollage_Click(object i_Sender, EventArgs e)
        {
            int i = 0;
            PictureBox currentPictureBox;
            List<Photo> photosToCollage = new List<Photo>();

            foreach(Control currentControl in panelCollageContainer.Controls)
            {
                if(currentControl.GetType() == typeof(PictureBox))
                {
                    currentPictureBox = null;
                }
            }

            if(listBoxPhotosList.SelectedItems.Count > 4)
            {
                MessageBox.Show("You have selected more than 4 photos");
            }
            else
            {
                foreach(Photo currentSelectedPhoto in listBoxPhotosList.SelectedItems)
                {
                    photosToCollage.Add(currentSelectedPhoto);
                }

                foreach(Control currentControl in panelCollageContainer.Controls)
                {
                    if(currentControl.GetType() == typeof(PictureBox))
                    {
                        currentPictureBox = (PictureBox)currentControl;
                        currentPictureBox.Visible = true;
                        currentPictureBox.LoadAsync(photosToCollage[i]?.PictureNormalURL);
                        i++;
                    }
                }
            }
        }

        private void listBoxPhotosList_SelectedValueChanged(object sender, EventArgs e)
        {
            pictureBoxSample.LoadAsync((listBoxPhotosList.SelectedItem as Photo)?.PictureNormalURL);
        }
    }
}








