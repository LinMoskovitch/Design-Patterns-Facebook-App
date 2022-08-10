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
    public partial class FormGroups : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormGroups(FacebookUserManager i_FacebookUserManager)
        {
            InitializeComponent();
            r_FacebookUserManager = i_FacebookUserManager;
        }

        private void buttonFetchGroups_Click(object i_Sender, EventArgs i_E)
        {
            fetchGroups();
        }

        private void listBoxGroupsList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            if (listBoxGroupsList.Items.Count != 0)
            {
                labelCoverPhoto.Visible = true;
                pictureBoxGroupsCoverPhoto.LoadAsync((listBoxGroupsList.SelectedItem as Group)?.PictureLargeURL);
            }
        }

        private void fetchGroups()
        {
            listBoxGroupsList.Items.Clear();
            foreach (Group userGroup in r_FacebookUserManager.LoggedInUserGroups)
            {
                listBoxGroupsList.Items.Add(userGroup);
            }

            if (listBoxGroupsList.Items.Count == 0)
            {
                MessageBox.Show("No groups to fetch.");
            }
        }

        private void FormGroups_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelGroups);
        }
    }
}
