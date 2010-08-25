namespace READOO
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotSearchesXML_Browse = new System.Windows.Forms.Button();
            this.pageTitlesXML_Browse = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hotSearchesXML = new System.Windows.Forms.TextBox();
            this.pageTitlesXML = new System.Windows.Forms.TextBox();
            this.keywordsLogForHumans = new System.Windows.Forms.TextBox();
            this.keywordsLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unwantedKeywords = new System.Windows.Forms.TextBox();
            this.htmlText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.runsBeforeCleaning = new System.Windows.Forms.TextBox();
            this.minimumOccurrencesToKeep = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LogDirectory_Browse = new System.Windows.Forms.Button();
            this.defaultSettings = new System.Windows.Forms.CheckBox();
            this.linux = new System.Windows.Forms.RadioButton();
            this.windows = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.systemLogFormat = new System.Windows.Forms.TextBox();
            this.logsDirectory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.plainText = new System.Windows.Forms.CheckBox();
            this.deliminatedFlatFile = new System.Windows.Forms.CheckBox();
            this.XML = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hotSearchesXML_Browse);
            this.groupBox1.Controls.Add(this.pageTitlesXML_Browse);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hotSearchesXML);
            this.groupBox1.Controls.Add(this.pageTitlesXML);
            this.groupBox1.Controls.Add(this.keywordsLogForHumans);
            this.groupBox1.Controls.Add(this.keywordsLog);
            this.groupBox1.Location = new System.Drawing.Point(16, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 168);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WHERE THINGS GO";
            // 
            // hotSearchesXML_Browse
            // 
            this.hotSearchesXML_Browse.BackgroundImage = global::READOO.Properties.Resources.browse;
            this.hotSearchesXML_Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hotSearchesXML_Browse.Location = new System.Drawing.Point(333, 142);
            this.hotSearchesXML_Browse.Name = "hotSearchesXML_Browse";
            this.hotSearchesXML_Browse.Size = new System.Drawing.Size(49, 20);
            this.hotSearchesXML_Browse.TabIndex = 37;
            this.hotSearchesXML_Browse.UseVisualStyleBackColor = true;
            this.hotSearchesXML_Browse.Click += new System.EventHandler(this.hotSearchesXML_Browse_Click);
            // 
            // pageTitlesXML_Browse
            // 
            this.pageTitlesXML_Browse.BackgroundImage = global::READOO.Properties.Resources.browse;
            this.pageTitlesXML_Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pageTitlesXML_Browse.Location = new System.Drawing.Point(333, 92);
            this.pageTitlesXML_Browse.Name = "pageTitlesXML_Browse";
            this.pageTitlesXML_Browse.Size = new System.Drawing.Size(49, 20);
            this.pageTitlesXML_Browse.TabIndex = 36;
            this.pageTitlesXML_Browse.UseVisualStyleBackColor = true;
            this.pageTitlesXML_Browse.Click += new System.EventHandler(this.pageTitlesXML_Browse_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Where to put the hot searches XML:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Where to put the page title XML:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Where you can read the keywords:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Where the program keeps its logs:";
            // 
            // hotSearchesXML
            // 
            this.hotSearchesXML.Location = new System.Drawing.Point(217, 118);
            this.hotSearchesXML.Name = "hotSearchesXML";
            this.hotSearchesXML.Size = new System.Drawing.Size(166, 20);
            this.hotSearchesXML.TabIndex = 5;
            this.hotSearchesXML.Text = "../xml/hotsearches.xml";
            this.hotSearchesXML.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // pageTitlesXML
            // 
            this.pageTitlesXML.Location = new System.Drawing.Point(217, 71);
            this.pageTitlesXML.Name = "pageTitlesXML";
            this.pageTitlesXML.Size = new System.Drawing.Size(166, 20);
            this.pageTitlesXML.TabIndex = 4;
            this.pageTitlesXML.Text = "../xml/pagetitles.xml";
            this.pageTitlesXML.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // keywordsLogForHumans
            // 
            this.keywordsLogForHumans.Location = new System.Drawing.Point(217, 45);
            this.keywordsLogForHumans.Name = "keywordsLogForHumans";
            this.keywordsLogForHumans.Size = new System.Drawing.Size(166, 20);
            this.keywordsLogForHumans.TabIndex = 2;
            this.keywordsLogForHumans.Text = "Keywords_ForHumans.txt";
            this.keywordsLogForHumans.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // keywordsLog
            // 
            this.keywordsLog.Location = new System.Drawing.Point(217, 19);
            this.keywordsLog.Name = "keywordsLog";
            this.keywordsLog.Size = new System.Drawing.Size(166, 20);
            this.keywordsLog.TabIndex = 1;
            this.keywordsLog.Text = "Keywords.log";
            this.keywordsLog.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.unwantedKeywords);
            this.groupBox2.Controls.Add(this.htmlText);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(426, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 90);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BLACKLIST AND HTML";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Text displayed with keywords:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "REGEX for unwanted keywords:";
            // 
            // unwantedKeywords
            // 
            this.unwantedKeywords.Location = new System.Drawing.Point(217, 22);
            this.unwantedKeywords.Name = "unwantedKeywords";
            this.unwantedKeywords.Size = new System.Drawing.Size(166, 20);
            this.unwantedKeywords.TabIndex = 21;
            this.unwantedKeywords.Text = "IllNeverBeCaught|MeNeither";
            this.unwantedKeywords.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // htmlText
            // 
            this.htmlText.Location = new System.Drawing.Point(217, 48);
            this.htmlText.Name = "htmlText";
            this.htmlText.Size = new System.Drawing.Size(166, 20);
            this.htmlText.TabIndex = 22;
            this.htmlText.Text = "People searched these terms to get here: ";
            this.htmlText.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.runsBeforeCleaning);
            this.groupBox3.Controls.Add(this.minimumOccurrencesToKeep);
            this.groupBox3.Location = new System.Drawing.Point(426, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 90);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CLEANING";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Minimum occurrences to keep:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Runs before cleaning:";
            // 
            // runsBeforeCleaning
            // 
            this.runsBeforeCleaning.Location = new System.Drawing.Point(217, 22);
            this.runsBeforeCleaning.Name = "runsBeforeCleaning";
            this.runsBeforeCleaning.Size = new System.Drawing.Size(166, 20);
            this.runsBeforeCleaning.TabIndex = 23;
            this.runsBeforeCleaning.Text = "10";
            this.runsBeforeCleaning.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // minimumOccurrencesToKeep
            // 
            this.minimumOccurrencesToKeep.Location = new System.Drawing.Point(217, 48);
            this.minimumOccurrencesToKeep.Name = "minimumOccurrencesToKeep";
            this.minimumOccurrencesToKeep.Size = new System.Drawing.Size(166, 20);
            this.minimumOccurrencesToKeep.TabIndex = 24;
            this.minimumOccurrencesToKeep.Text = "10";
            this.minimumOccurrencesToKeep.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LogDirectory_Browse);
            this.groupBox4.Controls.Add(this.defaultSettings);
            this.groupBox4.Controls.Add(this.linux);
            this.groupBox4.Controls.Add(this.windows);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.systemLogFormat);
            this.groupBox4.Controls.Add(this.logsDirectory);
            this.groupBox4.Location = new System.Drawing.Point(15, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(398, 135);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SERVER";
            // 
            // LogDirectory_Browse
            // 
            this.LogDirectory_Browse.BackgroundImage = global::READOO.Properties.Resources.browse;
            this.LogDirectory_Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogDirectory_Browse.Location = new System.Drawing.Point(334, 103);
            this.LogDirectory_Browse.Name = "LogDirectory_Browse";
            this.LogDirectory_Browse.Size = new System.Drawing.Size(49, 20);
            this.LogDirectory_Browse.TabIndex = 35;
            this.LogDirectory_Browse.UseVisualStyleBackColor = true;
            this.LogDirectory_Browse.Click += new System.EventHandler(this.LogsDirectory_Browse_Click);
            // 
            // defaultSettings
            // 
            this.defaultSettings.AutoSize = true;
            this.defaultSettings.Location = new System.Drawing.Point(91, 19);
            this.defaultSettings.Name = "defaultSettings";
            this.defaultSettings.Size = new System.Drawing.Size(105, 17);
            this.defaultSettings.TabIndex = 34;
            this.defaultSettings.Text = "Default settings?";
            this.defaultSettings.UseVisualStyleBackColor = true;
            this.defaultSettings.CheckedChanged += new System.EventHandler(this.defaultCheckBox_CheckedChanged);
            // 
            // linux
            // 
            this.linux.AutoSize = true;
            this.linux.Checked = true;
            this.linux.Location = new System.Drawing.Point(241, 18);
            this.linux.Name = "linux";
            this.linux.Size = new System.Drawing.Size(50, 17);
            this.linux.TabIndex = 33;
            this.linux.TabStop = true;
            this.linux.Text = "Linux";
            this.linux.UseVisualStyleBackColor = true;
            this.linux.Visible = false;
            this.linux.CheckedChanged += new System.EventHandler(this.settings_Changed);
            // 
            // windows
            // 
            this.windows.AutoSize = true;
            this.windows.Enabled = false;
            this.windows.Location = new System.Drawing.Point(314, 18);
            this.windows.Name = "windows";
            this.windows.Size = new System.Drawing.Size(38, 17);
            this.windows.TabIndex = 32;
            this.windows.Text = "IIS";
            this.windows.UseVisualStyleBackColor = true;
            this.windows.CheckedChanged += new System.EventHandler(this.settings_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Where the server keeps its logs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "How the server names its logs:";
            // 
            // systemLogFormat
            // 
            this.systemLogFormat.Enabled = false;
            this.systemLogFormat.Location = new System.Drawing.Point(217, 51);
            this.systemLogFormat.Name = "systemLogFormat";
            this.systemLogFormat.Size = new System.Drawing.Size(166, 20);
            this.systemLogFormat.TabIndex = 25;
            this.systemLogFormat.Text = "ex*.log";
            this.systemLogFormat.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // logsDirectory
            // 
            this.logsDirectory.Enabled = false;
            this.logsDirectory.Location = new System.Drawing.Point(217, 77);
            this.logsDirectory.Name = "logsDirectory";
            this.logsDirectory.Size = new System.Drawing.Size(166, 20);
            this.logsDirectory.TabIndex = 3;
            this.logsDirectory.Text = "C:\\WINDOWS\\system32\\LogFiles\\W3SVC1";
            this.logsDirectory.TextChanged += new System.EventHandler(this.settings_Changed);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(413, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "WC3 Extended Log format (with c-referrer) must be enabled on your server.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.plainText);
            this.groupBox5.Controls.Add(this.deliminatedFlatFile);
            this.groupBox5.Controls.Add(this.XML);
            this.groupBox5.Location = new System.Drawing.Point(426, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(398, 85);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OUTPUT";
            // 
            // plainText
            // 
            this.plainText.AutoSize = true;
            this.plainText.Location = new System.Drawing.Point(78, 29);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(69, 17);
            this.plainText.TabIndex = 34;
            this.plainText.Text = "Plain text";
            this.plainText.UseVisualStyleBackColor = true;
            this.plainText.CheckedChanged += new System.EventHandler(this.plainText_CheckedChanged);
            // 
            // deliminatedFlatFile
            // 
            this.deliminatedFlatFile.AutoSize = true;
            this.deliminatedFlatFile.Location = new System.Drawing.Point(153, 29);
            this.deliminatedFlatFile.Name = "deliminatedFlatFile";
            this.deliminatedFlatFile.Size = new System.Drawing.Size(114, 17);
            this.deliminatedFlatFile.TabIndex = 33;
            this.deliminatedFlatFile.Text = "Deliminated flat file";
            this.deliminatedFlatFile.UseVisualStyleBackColor = true;
            this.deliminatedFlatFile.CheckedChanged += new System.EventHandler(this.deliminatedFlatFile_Changed);
            // 
            // XML
            // 
            this.XML.AutoSize = true;
            this.XML.Location = new System.Drawing.Point(273, 29);
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(48, 17);
            this.XML.TabIndex = 32;
            this.XML.Text = "XML";
            this.XML.UseVisualStyleBackColor = true;
            this.XML.CheckedChanged += new System.EventHandler(this.XML_CheckedChanged);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackColor = System.Drawing.SystemColors.Control;
            this.save.Enabled = false;
            this.save.Image = global::READOO.Properties.Resources.saved;
            this.save.Location = new System.Drawing.Point(493, 375);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(159, 38);
            this.save.TabIndex = 19;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.BackColor = System.Drawing.SystemColors.Control;
            this.reset.Enabled = false;
            this.reset.Image = global::READOO.Properties.Resources.reset;
            this.reset.Location = new System.Drawing.Point(433, 375);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(54, 38);
            this.reset.TabIndex = 27;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.SystemColors.Control;
            this.exit.Image = global::READOO.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(658, 375);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(159, 38);
            this.exit.TabIndex = 20;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 423);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.MaximumSize = new System.Drawing.Size(845, 461);
            this.MinimumSize = new System.Drawing.Size(845, 461);
            this.Name = "SettingsWindow";
            this.Text = "READOO SETTINGS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keywordsLog;
        private System.Windows.Forms.TextBox keywordsLogForHumans;
        private System.Windows.Forms.TextBox logsDirectory;
        private System.Windows.Forms.TextBox pageTitlesXML;
        private System.Windows.Forms.TextBox hotSearchesXML;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox unwantedKeywords;
        private System.Windows.Forms.TextBox htmlText;
        private System.Windows.Forms.TextBox runsBeforeCleaning;
        private System.Windows.Forms.TextBox minimumOccurrencesToKeep;
        private System.Windows.Forms.TextBox systemLogFormat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton windows;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton linux;
        private System.Windows.Forms.CheckBox plainText;
        private System.Windows.Forms.CheckBox deliminatedFlatFile;
        private System.Windows.Forms.CheckBox XML;
        private System.Windows.Forms.CheckBox defaultSettings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button LogDirectory_Browse;
        private System.Windows.Forms.Button hotSearchesXML_Browse;
        private System.Windows.Forms.Button pageTitlesXML_Browse;
    }
}