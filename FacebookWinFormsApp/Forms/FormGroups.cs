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
            foreach (Group userGroup in r_FacebookUserManager.LoggedInUser.Groups)
            {
                listBoxGroupsList.Items.Add(userGroup);
            }

            if (listBoxGroupsList.Items.Count == 0)
            {
                MessageBox.Show("No groups to fetch.");
            }
        }

        private void loadTheme()
        {
            Button currentButton;
            Label currentLabel;

            foreach (Control currentControl in panelGroups.Controls)
            {
                if (currentControl.GetType() == typeof(Button))
                {
                    currentButton = (Button)currentControl;
                    currentButton.BackColor = UIThemeColor.PrimaryColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.FlatAppearance.BorderColor = UIThemeColor.SecondaryColor;
                }

                if (currentControl.GetType() == typeof(Label))
                {
                    currentLabel = (Label)currentControl;
                    currentLabel.ForeColor = UIThemeColor.PrimaryColor;
                }
            }
        }

       

        private void FormGroups_Load(object sender, EventArgs e)
        {
            loadTheme();
        }
    }
}
