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
    public partial class FacebookForm : Form
    {
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private const bool k_IsComponentsVisible = true;
        private const bool k_IsEnableOptions = true;


        public FacebookForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            Clipboard.SetText("CagLyU9?BsQ2r?9"); /// Lin's current password

            m_LoginResult = FacebookService.Login(
                "768643954263924",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_access_member_info");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Enabled = false;
                pictureBoxProfiePicture.Visible = true;
                pictureBoxProfiePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
                setEnableApplicationOptions(k_IsEnableOptions);
                setLoginEnable(!k_IsEnableOptions);
            }
            else
            {
                MessageBox.Show("Error occurred while trying to login ");
            }
        }

        private void setEnableApplicationOptions(bool i_IsEnable)
        {
            buttonUserInfo.Enabled = i_IsEnable;
            buttonAlbums.Enabled = i_IsEnable;
            buttonGroups.Enabled = i_IsEnable;
            buttonPages.Enabled = i_IsEnable;
            buttonEvents.Enabled = i_IsEnable;
            buttonFeature1.Enabled = i_IsEnable;
            buttonFeature2.Enabled = i_IsEnable;
            buttonLogout.Enabled = i_IsEnable;
        }

        private void setLoginEnable(bool i_IsEnable)
        {
            buttonLogout.Enabled = !i_IsEnable;
            buttonLogin.Enabled = i_IsEnable;
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
            buttonLogin.Enabled = true;
            m_LoginResult = null;
            m_LoggedInUser = null;
            pictureBoxProfiePicture.Visible = false;
            setEnableApplicationOptions(!k_IsEnableOptions);
        }
    }
}
