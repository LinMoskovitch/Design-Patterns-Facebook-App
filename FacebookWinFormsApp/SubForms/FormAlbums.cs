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

        private void buttonFetchAlbums_Click(object i_Sender, EventArgs i_E)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbumsList.Items.Clear();
            foreach(Album userAlbum in r_FacebookUserManager.LoggedInUserAlbums)
            {
                listBoxAlbumsList.Items.Add(userAlbum);
            }

            if (listBoxAlbumsList.Items.Count == 0)
            {
                MessageBox.Show("No albums to fetch.");
            }
        }

        private void listBoxAlbumsList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            DateTime? dateTime;
            DateTime createdTime;

            if (listBoxAlbumsList.Items.Count != 0)
            {
                labelCoverPhoto.Visible = true;
                pictureBoxAlbumsCoverPhoto.LoadAsync((listBoxAlbumsList.SelectedItem as Album)?.PictureAlbumURL);
                labelDateCreated.Visible = true;
                dateTime = (listBoxAlbumsList.SelectedItem as Album)?.CreatedTime;
                if(dateTime != null)
                {
                    createdTime = (DateTime)dateTime;
                    textBoxDateCreated.Text = createdTime.ToString("d");
                }
            }
        }

        private void FormAlbums_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelAlbums);
        }

        private void buttonSortAlbums_Click(object i_Sender, EventArgs i_E)
        {
            List<Album> sortedAlbumsList;

            if (listBoxAlbumsList.Items.Count != 0)
            {
                if (radioButtonSortByDate.Checked)
                {
                    sortedAlbumsList = listBoxAlbumsList.Items.Cast<Album>()
                        .OrderByDescending(i_Album => i_Album.CreatedTime).ToList();
                    listBoxAlbumsList.Items.Clear();
                    foreach (Album album in sortedAlbumsList)
                    {
                        listBoxAlbumsList.Items.Add(album);
                    }
                }
                else if (radioButtonSortByAmountOfPhotos.Created)
                {
                    sortedAlbumsList = listBoxAlbumsList.Items.Cast<Album>()
                        .OrderByDescending(i_Album => i_Album.Photos.Count).ToList();
                    listBoxAlbumsList.Items.Clear();
                    foreach (Album album in sortedAlbumsList)
                    {
                        listBoxAlbumsList.Items.Add(album);
                    }
                }
            }
        }
    }
}
