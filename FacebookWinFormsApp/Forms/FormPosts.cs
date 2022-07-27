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
    public partial class FormPosts : Form
    {
        private readonly User r_LoggedInUser;

        public FormPosts(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        private void buttonFetchPosts_Click(object i_Sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            listBoxPostsList.Items.Clear();
            foreach(Post userPost in r_LoggedInUser.Posts)
            {
                listBoxPostsList.Items.Add(userPost);
                //if (userPost.Message != null)
                //{
                //    listBoxPostsList.Items.Add(userPost.Message);
                //}
                //else if(userPost.Caption != null)
                //{
                //    listBoxPostsList.Items.Add(userPost.Caption);
                //}
                //else
                //{
                //    listBoxPostsList.Items.Add($"[{userPost.Type}]");
                //}
            }

            if(listBoxPostsList.Items.Count == 0)
            {
                MessageBox.Show("No posts to fetch.");
            }
        }

        private void listBoxEventsList_SelectedValueChanged(object i_Sender, EventArgs e)
        {
            pictureBoxPostPhotoDisplay.Visible = false;
            listBoxCommentsList.Items.Clear();

            if (listBoxPostsList.Items.Count != 0)
            {
                if(((Post)listBoxPostsList.SelectedItem).Type.Equals(Post.eType.photo))
                {
                    pictureBoxPostPhotoDisplay.Visible = true;
                    pictureBoxPostPhotoDisplay.LoadAsync(((Post)listBoxPostsList.SelectedItem)?.PictureURL);
                }

                if(((Post)listBoxPostsList.SelectedItem).Comments.Count != 0)
                {
                    foreach(Comment comment in ((Post)listBoxPostsList.SelectedItem).Comments)
                    {
                        listBoxCommentsList.Items.Add(comment.Message);
                    }
                }
                else
                {
                    listBoxCommentsList.Items.Add("No comments on this post.");
                }
            }
        }

        private void buttonAddNewPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            buttonPostNewStatus.Enabled = !textBoxStatus.Text.Equals(String.Empty);
        }
    }
}

