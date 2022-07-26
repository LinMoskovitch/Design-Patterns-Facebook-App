﻿using System;
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
    public partial class FormPages : Form
    {
        private readonly FacebookUserManager r_FacebookUserManager;

        public FormPages(FacebookUserManager i_FacebookUserManager)
        {
            InitializeComponent();
            r_FacebookUserManager = i_FacebookUserManager;
        }

        private void listBoxPagesList_SelectedValueChanged(object i_Sender, EventArgs i_E)
        {
            if (listBoxPagesList.Items.Count != 0)
            {
                labelCoverPhoto.Visible = true;
                pictureBoxPagesCoverPhoto.LoadAsync((listBoxPagesList.SelectedItem as Page)?.PictureLargeURL);
            }
        }

        private void buttonFetchPages_Click(object i_Sender, EventArgs i_E)
        {
            fetchPages();
        }

        private void fetchPages()
        {
            listBoxPagesList.Items.Clear();
            foreach (Page userPage in r_FacebookUserManager.LoggedInUserPages)
            {
                listBoxPagesList.Items.Add(userPage);
            }

            if (listBoxPagesList.Items.Count == 0)
            {
                MessageBox.Show("No pages to fetch.");
            }
        }

        private void FormPages_Load(object i_Sender, EventArgs i_E)
        {
            UIThemeColor.LoadTheme(panelPages);
        }
    }
}
