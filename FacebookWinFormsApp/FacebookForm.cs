using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
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
        private Form m_ActiveForm;


        public FacebookForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object i_Sender, EventArgs e)
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


        private void buttonLogout_Click(object i_Sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
            buttonLogin.Enabled = true;
            m_LoginResult = null;
            m_LoggedInUser = null;
            setEnableApplicationOptions(!k_IsEnableOptions);
        }

        private void openChildForm(Form i_ChildForm, object i_Sender)
        {
            m_ActiveForm?.Close();

            m_ActiveForm = i_ChildForm;
            i_ChildForm.TopLevel = false;
            i_ChildForm.FormBorderStyle = FormBorderStyle.None;
            i_ChildForm.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(i_ChildForm);
            panelDesktopPanel.Tag = i_ChildForm;
            i_ChildForm.BringToFront();
            i_ChildForm.Show();
            labelTitleBar.Text = i_ChildForm.Text;
        }

        private void buttonUserInfo_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormUserInfo(m_LoggedInUser), i_Sender);
        }

        private void buttonAlbums_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormAlbums(), i_Sender);
        }

        private void buttonGroups_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormGroups(), i_Sender);
        }

        private void buttonPages_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormPages(), i_Sender);
        }

        private void buttonEvents_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormEvents(), i_Sender);
        }

        private void buttonFeature1_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormFeature1(), i_Sender);
        }

        private void buttonFeature2_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormFeature2(), i_Sender);
        }
    }
}
