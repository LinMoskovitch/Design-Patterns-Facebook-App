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
        private const bool k_IsEnableOptions = true;
        private Form m_ActiveForm;
        private Button m_CurrentSelectedButton;
        private readonly Random r_Random;
        private int m_RandomColorIndex;

        public FacebookForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_Random = new Random();
        }

        private Color selectThemeColor()
        {
            int index = r_Random.Next(UIThemeColor.m_MenuColorsList.Count);
            while (m_RandomColorIndex == index)
            {
                index = r_Random.Next(UIThemeColor.m_MenuColorsList.Count);
            }
            m_RandomColorIndex = index;
            string color = UIThemeColor.m_MenuColorsList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void selectButton(object i_BtnSender)
        {
            if (i_BtnSender != null && m_CurrentSelectedButton != (Button)i_BtnSender)
            {
                deselectButton();
                Color color = selectThemeColor();
                m_CurrentSelectedButton = (Button)i_BtnSender;
                m_CurrentSelectedButton.BackColor = color;
                m_CurrentSelectedButton.ForeColor = Color.White;
                m_CurrentSelectedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panelTitleBar.BackColor = color;
                panelLogo.BackColor = UIThemeColor.ChangeColorBrightness(color, -0.3);
            }
        }

        private void deselectButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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
            buttonPosts.Enabled = i_IsEnable;
            buttonCollage.Enabled = i_IsEnable;
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
            selectButton(i_Sender);
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
            openChildForm(new Forms.FormAlbums(m_LoggedInUser), i_Sender);
        }

        private void buttonGroups_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormGroups(m_LoggedInUser), i_Sender);
        }

        private void buttonPages_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormPages(m_LoggedInUser), i_Sender);
        }

        private void buttonEvents_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormPosts(m_LoggedInUser), i_Sender);
        }

        private void buttonFeature1_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormCollage(m_LoggedInUser), i_Sender);
        }

        private void buttonFeature2_Click(object i_Sender, EventArgs e)
        {
            openChildForm(new Forms.FormFeature2(m_LoggedInUser), i_Sender);
        }

    }
}
