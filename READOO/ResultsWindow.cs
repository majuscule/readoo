using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace READOO
{
    public partial class ResultsWindow : Form
    {
        public void _update_Delegate(int percent, string status)
        {
            backgroundWorker.ReportProgress(percent, status);
        }

        public ResultsWindow()
        {
            InitializeComponent();
            done.Hide();
            settings.Hide();
            viewAsTextDoc.Hide();
            backgroundWorker.RunWorkerAsync();
        }


        private void done_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            Close();
        }

        private void exit(object sender, FormClosedEventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            Close();
        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Cancel == true) { backgroundWorker.CancelAsync(); }
            HarvestKeywords.Run(_update_Delegate);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            status.Text = e.UserState + " . . .";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            results.Text = Get_ResultsForHumans();

            progressBar.Hide();
            status.Hide();

            viewAsTextDoc.Show();
            settings.Show();
            done.Show();
            before_READOO_bg.Hide();
        }

        public string Get_ResultsForHumans()
        {
            string results = "";
            if (Properties.Settings.Default.PlainText)
            {
                string line;
                using (StreamReader r = new StreamReader("Keywords_ForHumans.txt"))
                {
                    while ((line = r.ReadLine()) != null)
                    {
                        results += line + "\r\n";
                    }
                }
            }
            else
            {
                results = "Run complete. Keywords updated. \r\n You opted not to have a plain text version. (Click settings to change)";
            }

            return results;
        }


        private void view_KeywordsForHumans_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("keywords_forhumans.txt");
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Form SettingsWindow = new SettingsWindow();
            SettingsWindow.ShowDialog();
        }
    }
}
