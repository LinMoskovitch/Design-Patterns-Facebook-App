using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private User m_TheLoggedInUser { get; set; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "768643954263924", 
                    /// requested permissions:
					"email",
                    "public_profile"
                    /// add any relevant permissions
                    );
            if(loginResult.AccessToken != null)
            {
                m_TheLoggedInUser = loginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_TheLoggedInUser.Name}";
                pictureBoxProfilePicture.Visible = true;
                pictureBoxProfilePicture.Image = m_TheLoggedInUser.ImageNormal;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}
    }
}
