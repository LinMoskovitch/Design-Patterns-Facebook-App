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

        private User TheLoggedInUser { get; set; }
        private UserControlPostsDisplay UserControlPostsDisplay { }

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
                TheLoggedInUser = loginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {TheLoggedInUser.Name}";
                pictureBoxProfilePicture.Visible = true;
                pictureBoxProfilePicture.Image = TheLoggedInUser.ImageNormal;
                labelFullName.Text = TheLoggedInUser.Name;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
            TheLoggedInUser = null;
            pictureBoxProfilePicture.Visible = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxProfilePicture_Click(object sender, EventArgs e)
        {

        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            
        }
    }
}
