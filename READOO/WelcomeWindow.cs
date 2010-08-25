﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace READOO
{
    public partial class WelcomeWindow : Form
    {

        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Form SettingsWindow = new SettingsWindow();
            SettingsWindow.ShowDialog();
        }

        // DISABLE IF ALREADY UP TO DATE UNLESS A FILE HAS BEEN MODIFIED
        // MUST BE DISABLED VISUALLY, BUT CHANGE ON STATUS CHANGE
        private void RunReadooNow_Click(object sender, EventArgs e)
        {
            Form ResultsWindow = new ResultsWindow();
            ResultsWindow.ShowDialog();
        }


        private void creditsAndLicense_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void creditsAndLicense_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void creditsAndLicense_Click(object sender, EventArgs e)
        {
            Form CreditsAndLicenseWindow = new CreditsAndLicenseWindow();
            CreditsAndLicenseWindow.ShowDialog();
        }
    }
}