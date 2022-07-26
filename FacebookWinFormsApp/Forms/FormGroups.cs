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
    public partial class FormGroups : Form
    {

        private readonly User r_LoggedInUser;

        public FormGroups(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        private void buttonFetchGroups_Click(object i_Sender, EventArgs e)
        {
            fetchGroups();
        }

        private void listBoxGroupsList_SelectedValueChanged(object i_Sender, EventArgs e)
        {
            if (listBoxGroupsList.Items.Count != 0)
            {
                pictureBoxGroupsCoverPhoto.LoadAsync((listBoxGroupsList.SelectedItem as Group)?.PictureNormalURL);
            }
        }

        private void fetchGroups()
        {
            listBoxGroupsList.Items.Clear();
            foreach (Group userGroup in r_LoggedInUser.Groups)
            {
                listBoxGroupsList.Items.Add(userGroup);
            }

            if (listBoxGroupsList.Items.Count == 0)
            {
                MessageBox.Show("No groups to fetch.");
            }
        }


    }
}
