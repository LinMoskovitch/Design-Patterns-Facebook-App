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
    public partial class FormAlbums : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormAlbums(FacebookUserManager i_FacebookUserManager)
        {
            InitializeComponent();
            r_FacebookUserManager = i_FacebookUserManager;
        }

        private void loadTheme()
        {
            Button currentButton;
            Label currentLabel;

            foreach (Control currentControl in panelAlbums.Controls)
            {
                if (currentControl.GetType() == typeof(Button))
                {
                    currentButton = (Button)currentControl;
                    currentButton.BackColor = UIThemeColor.PrimaryColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.FlatAppearance.BorderColor = UIThemeColor.SecondaryColor;
                }

                if(currentControl.GetType() == typeof(Label))
                {
                    currentLabel = (Label)currentControl;
                    currentLabel.ForeColor = UIThemeColor.PrimaryColor;
                }
            }
        }

        private void buttonFetchAlbums_Click(object i_Sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbumsList.Items.Clear();
            foreach(Album userAlbum in r_FacebookUserManager.LoggedInUser.Albums)
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

        private void FormAlbums_Load(object sender, EventArgs e)
        {
            loadTheme();
        }
    }
}
