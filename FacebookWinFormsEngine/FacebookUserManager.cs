using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsEngine
{
    public class FacebookUserManager
    {
        private LoginResult m_LoginResult;
        public User LoggedInUser { get; private set; }

        public bool Login()
        {
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
                "groups_access_member_info",
                "publish_to_groups",
                "pages_manage_posts");
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                LoggedInUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                LoggedInUser = null;
            }

            return LoggedInUser != null;
        }

        public void Logout()
        {
            FacebookService.Logout();
        }
    }
}
