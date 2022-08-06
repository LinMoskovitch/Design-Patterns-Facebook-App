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
    public partial class FormUserInfo : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormUserInfo(FacebookUserManager i_FacebookUserManager)
        {
            InitializeComponent();
            r_FacebookUserManager = i_FacebookUserManager;
            fetchAndDisplayUserInfo();
        }

        private void fetchAndDisplayUserInfo()
        {
            labelUserInfoWelcome.Text += r_FacebookUserManager.LoggedInUser.FirstName + "!";
            labelUserInfoName.Text += r_FacebookUserManager.LoggedInUser.Name;
            labelUserInfoEmail.Text += r_FacebookUserManager.LoggedInUser.Email;
            labelUserInfoGender.Text += r_FacebookUserManager.LoggedInUser.Gender.ToString();
            labelUserBirthDate.Text += r_FacebookUserManager.LoggedInUser.Birthday;
            pictureBoxUserInfoProfilePicture.Visible = true;
            pictureBoxUserInfoProfilePicture.LoadAsync(r_FacebookUserManager.LoggedInUser.PictureNormalURL);
        }

        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            UIThemeColor.LoadTheme(panelUserInfo);
        }
    }
}
