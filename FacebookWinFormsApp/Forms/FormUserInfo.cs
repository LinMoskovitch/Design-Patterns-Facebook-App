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
    public partial class FormUserInfo : Form
    {
        private readonly User r_LoggedInUser;

        public FormUserInfo(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
            fetchAndDisplayUserInfo();
        }

        private void fetchAndDisplayUserInfo()
        {
            labelUserInfoWelcome.Text += r_LoggedInUser.FirstName + "!";
            labelUserInfoName.Text += r_LoggedInUser.Name;
            labelUserInfoEmail.Text += r_LoggedInUser.Email;
            labelUserInfoGender.Text += r_LoggedInUser.Gender.ToString();
            labelUserBirthDate.Text += r_LoggedInUser.Birthday;
            pictureBoxUserInfoProfilePicture.Visible = true;
            pictureBoxUserInfoProfilePicture.LoadAsync(r_LoggedInUser.PictureNormalURL);


        }


    }
}
