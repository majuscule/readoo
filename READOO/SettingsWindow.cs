using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using READOO.Properties;

namespace READOO
{
    public partial class SettingsWindow : Form
    {
        bool settings_ChangedFlag = false;


        public SettingsWindow()
        {
            InitializeComponent();

            defaultSettings.Checked = Settings.Default.defaultServerSettings;
            if (Settings.Default.chosenOS == "windows") { windows.Checked = true; }
            else if (Settings.Default.chosenOS == "linux") { linux.Checked = true; }
            plainText.Checked = Settings.Default.PlainText;
            deliminatedFlatFile.Checked = Settings.Default.deliminatedFlatFile;
            XML.Checked = Settings.Default.XML;
                if (XML.Checked)
                {
                    pageTitlesXML.Enabled = true;
                    pageTitlesXML_Browse.Enabled = true;
                    hotSearchesXML.Enabled = true;
                    hotSearchesXML_Browse.Enabled = true;
                    htmlText.Enabled = true;
                }
                else
                {
                    pageTitlesXML.Enabled = false;
                    pageTitlesXML_Browse.Enabled = false;
                    hotSearchesXML.Enabled = false;
                    hotSearchesXML_Browse.Enabled = false;
                    htmlText.Enabled = false;
                }

            save.Image = READOO.Properties.Resources.saved;
            save.Enabled = false;
            settings_ChangedFlag = false;

        }


        private void reset_Click(object sender, EventArgs e)
        {
            keywordsLog.Text = Settings.Default.default_KeywordsLog;
            keywordsLogForHumans.Text = Settings.Default.default_KeywordsLogForHumans;
            pageTitlesXML.Text = Settings.Default.default_PageTitlesXML;
            hotSearchesXML.Text = Settings.Default.default_HotSearchesXML;
            logsDirectory.Text = Settings.Default.default_LogsDirectory;
            unwantedKeywords.Text = Settings.Default.default_UnwantedKeywords;
            runsBeforeCleaning.Text = Convert.ToString(Settings.Default.default_RunsBeforeCleaning);
            minimumOccurrencesToKeep.Text = Convert.ToString(Settings.Default.default_MinimumOccurrencesToKeep);
            systemLogFormat.Text = Settings.Default.default_SystemLogFormat;

            defaultSettings.Checked = true;
            linux.Checked = true;
            plainText.Checked = true;
            deliminatedFlatFile.Checked = true;
        }


        private void settings_Changed(object sender, EventArgs e)
        {
            settings_ChangedFlag = true;
            save.Image = READOO.Properties.Resources.save;
            save.Enabled = true;
            reset.Enabled = true;
        }

        private void settings_Changed()
        {
            settings_ChangedFlag = true;
            save.Image = READOO.Properties.Resources.save;
            save.Enabled = true;
            reset.Enabled = true;
        }


        private void save_Click(object sender, EventArgs e)
        {
            save_Changes();
        }

        private void save_Changes()
        {
            Settings.Default.KeywordsLog = keywordsLog.Text;
            Settings.Default.KeywordsLogForHumans = keywordsLogForHumans.Text;
            Settings.Default.LogsDirectory = logsDirectory.Text;
            Settings.Default.UnwantedKeywords = unwantedKeywords.Text;
            Settings.Default.RunsBeforeCleaning = Convert.ToInt32(runsBeforeCleaning.Text);
            Settings.Default.MinimumOccurrencesToKeep = Convert.ToInt32(minimumOccurrencesToKeep.Text);
            Settings.Default.SystemLogFormat = systemLogFormat.Text;

            Settings.Default.defaultServerSettings = defaultSettings.Checked;
                if (windows.Checked) { Settings.Default.chosenOS = "windows"; }
                if (linux.Checked) { Settings.Default.chosenOS = "linux"; }
            Settings.Default.PlainText = plainText.Checked;
            Settings.Default.deliminatedFlatFile = deliminatedFlatFile.Checked;
            Settings.Default.XML = XML.Checked;
            

            save.Image = READOO.Properties.Resources.saved;
            save.Enabled = false;
            settings_ChangedFlag = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (settings_ChangedFlag)
            {
                DialogResult Result = MessageBox.Show("Save changes before exiting?",
                    "WAIT!", MessageBoxButtons.YesNoCancel);
                if (Result == DialogResult.Yes) { save_Changes(); }
                else if (Result == DialogResult.No) { }
                else if (Result == DialogResult.Cancel) { e.Cancel = true; }
            }
        }


        private void defaultCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultSettings.Checked)
            {
                systemLogFormat.Enabled = false;
                logsDirectory.Enabled = false;
                LogDirectory_Browse.Enabled = false;
                windows.Enabled = true;
                linux.Enabled = true;
            }
            else
            {
                systemLogFormat.Enabled = true;
                logsDirectory.Enabled = true;
                LogDirectory_Browse.Enabled = true;
                windows.Enabled = false;
                linux.Enabled = false;
            }
            settings_Changed();
        }

        private void deliminatedFlatFile_Changed(object sender, EventArgs e)
        {
            //TURN OFF FLAT FILE
            settings_Changed();
        }

        private void XML_CheckedChanged(object sender, EventArgs e)
        {
            if (XML.Checked)
            {
                pageTitlesXML.Enabled = true;
                pageTitlesXML_Browse.Enabled = true;
                hotSearchesXML.Enabled = true;
                hotSearchesXML_Browse.Enabled = true;
                htmlText.Enabled = true;
            }
            else
            {
                pageTitlesXML.Enabled = false;
                pageTitlesXML_Browse.Enabled = false;
                hotSearchesXML.Enabled = false;
                hotSearchesXML_Browse.Enabled = false;
                htmlText.Enabled = false;
            }
            settings_Changed();
        }

        private void plainText_CheckedChanged(object sender, EventArgs e)
        {
            //TURN OFF KEYWORDS LOG FOR HUMANS
            if (plainText.Checked)
            {
                keywordsLogForHumans.Enabled = true;
            }
            else
            {
                keywordsLogForHumans.Enabled = false;
            }
            settings_Changed();
        }


        private void pageTitlesXML_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.ShowDialog();
            try
            {
                if (FileDialog.FileName != "")
                {
                    pageTitlesXML.Text = FileDialog.FileName;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error opening file", "File Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void hotSearchesXML_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.ShowDialog();
            try
            {
                if (FileDialog.FileName != "")
                {
                    hotSearchesXML.Text = FileDialog.FileName; 
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error opening file", "File Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void systemLogFormat_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            FolderBrowser.ShowDialog();
            if (FolderBrowser.SelectedPath != string.Empty)
                systemLogFormat.Text = FolderBrowser.SelectedPath;
        }

        private void LogsDirectory_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            FolderBrowser.ShowDialog();
            if (FolderBrowser.SelectedPath != string.Empty)
                logsDirectory.Text = FolderBrowser.SelectedPath;
        }
    }
}
