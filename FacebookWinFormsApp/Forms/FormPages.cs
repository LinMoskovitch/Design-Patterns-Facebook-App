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
    public partial class FormPages : Form
    {
        private readonly User r_LoggedInUser;

        public FormPages(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        private void listBoxPagesList_SelectedValueChanged(object i_Sender, EventArgs e)
        {
            if (listBoxPagesList.Items.Count != 0)
            {
                pictureBoxPagesCoverPhoto.LoadAsync((listBoxPagesList.SelectedItem as Page)?.PictureURL);
            }
        }

        private void buttonFetchPages_Click(object i_Sender, EventArgs e)
        {
            fetchPages();
        }

        private void fetchPages()
        {
            listBoxPagesList.Items.Clear();
            foreach (Page userPage in r_LoggedInUser.LikedPages)
            {
                listBoxPagesList.Items.Add(userPage);
            }

            if (listBoxPagesList.Items.Count == 0)
            {
                MessageBox.Show("No pages to fetch.");
            }
        }
    }
}
