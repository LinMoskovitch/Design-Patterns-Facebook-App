using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormAlbums : Form
    {
        private readonly User r_LoggedInUser;

        public FormAlbums(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        private void buttonFetchAlbums_Click(object i_Sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbumsList.Items.Clear();
            foreach(Album userAlbum in r_LoggedInUser.Albums)
            {
                listBoxAlbumsList.Items.Add(userAlbum);
            }

            if (listBoxAlbumsList.Items.Count == 0)
            {
                MessageBox.Show("No albums to fetch.");
            }
        }

        private void listBoxAlbumsList_SelectedValueChanged(object i_Sender, EventArgs e)
        {
            if(listBoxAlbumsList.Items.Count != 0)
            {
                pictureBoxAlbumsCoverPhoto.LoadAsync((listBoxAlbumsList.SelectedItem as Album)?.PictureAlbumURL);
            }
        }

        private void panelAlbums_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxAlbumsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxAlbumsCoverPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
