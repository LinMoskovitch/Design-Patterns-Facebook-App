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
    public partial class FormEvents : Form
    {
        private readonly User r_LoggedInUser;

        public FormEvents(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        private void buttonFetchEvents_Click(object i_Sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEventsList.Items.Clear();
            foreach(Album userAlbum in r_LoggedInUser.Albums)
            {
                listBoxEventsList.Items.Add(userAlbum);
            }

            if(listBoxEventsList.Items.Count == 0)
            {
                MessageBox.Show("No events to fetch.");
            }
        }

        private void listBoxAlbumsList_SelectedValueChanged(object i_Sender, EventArgs e)
            {
                if (listBoxEventsList.Items.Count != 0)
                {
                    pictureBoxEventsCoverPhoto.LoadAsync((listBoxEventsList.SelectedItem as Album)?.PictureAlbumURL);
                }
            }
        }
    }

