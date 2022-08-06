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
        private FacebookObjectCollection<Post> m_LoggedInUserPosts = null;
        private FacebookObjectCollection<Group> m_LoggedInUserGroups = null;
        private FacebookObjectCollection<Page> m_LoggedInUserPages = null;
        private FacebookObjectCollection<Album> m_LoggedInUserAlbums = null;

        public User LoggedInUser { get; private set; } = null;


        public FacebookObjectCollection<Post> LoggedInUserPosts 
        {
            get 
            {
                if (m_LoggedInUserPosts == null)
                {
                    FetchPosts();
                }

                return m_LoggedInUserPosts;
            }

            private set
            {
                m_LoggedInUserPosts = value;
            }
        }
        public FacebookObjectCollection<Group> LoggedInUserGroups
        {
            get
            {
                if (m_LoggedInUserGroups == null)
                {
                    FetchGroups();
                }

                return m_LoggedInUserGroups;
            }

            private set
            {
                m_LoggedInUserGroups = value;
            }
        }

        public FacebookObjectCollection<Page> LoggedInUserPages
        {
            get
            {
                if (m_LoggedInUserPages == null)
                {
                    FetchPages();
                }

                return m_LoggedInUserPages;
            }

            private set
            {
                m_LoggedInUserPages = value;
            }
        }

        public FacebookObjectCollection<Album> LoggedInUserAlbums
        {
            get
            {
                if (m_LoggedInUserAlbums == null)
                {
                    FetchAlbums();
                }

                return m_LoggedInUserAlbums;
            }

            private set
            {
                m_LoggedInUserAlbums = value;
            }
        }

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
                "pages_manage_posts",
                "pages_read_user_content");
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
            LoggedInUser = null;
            LoggedInUserPosts = null;
            LoggedInUserAlbums = null;
            LoggedInUserGroups = null;
            LoggedInUserPages = null;
        }

        public void FetchPosts()
        {
            if(LoggedInUser != null)
            {
                LoggedInUserPosts = LoggedInUser.Posts;
            }
        }

        public void FetchGroups()
        {
            if (LoggedInUser != null)
            {
                LoggedInUserGroups = LoggedInUser.Groups;
            }
        }
        
        public void FetchPages()
        {
            if (LoggedInUser != null)
            {
                LoggedInUserPages = LoggedInUser.LikedPages;
            }
        }

        public void FetchAlbums()
        {
            if (LoggedInUser != null)
            {
                LoggedInUserAlbums = LoggedInUser.Albums;
            }
        }

        public Status PostStatus(String i_StatusMessage)
        {
            Status postedStatus = null;

            if (LoggedInUser != null)
            {
                postedStatus = LoggedInUser.PostStatus(i_StatusMessage);
            }
            else
            {
                throw new Exception("No user is logged in");
            }

            return postedStatus;
        }

        public List<Post> FilterPostsByKeyword(string i_Keyword)
        {
            List<Post> filteredPosts = new List<Post>();

            if (LoggedInUserPosts != null)
            {
                foreach (Post userPost in LoggedInUserPosts)
                {
                    if ((userPost.Message != null && userPost.Message.Contains(i_Keyword)) ||
                       (userPost.Description != null && userPost.Description.Contains(i_Keyword)) ||
                       (userPost.Caption != null && userPost.Caption.Contains(i_Keyword)) ||
                       i_Keyword == string.Empty)
                    {
                        filteredPosts.Add(userPost);
                    }
                }
            }

            return filteredPosts;
        }
    }
}
