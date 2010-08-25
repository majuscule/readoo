namespace READOO
{
    partial class ResultsWindow
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
            this.cancel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.status = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.Label();
            this.contentBox = new System.Windows.Forms.Panel();
            this.before_READOO_bg = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.Button();
            this.viewAsTextDoc = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.contentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.before_READOO_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.Location = new System.Drawing.Point(554, 453);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(159, 38);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(11, 423);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(699, 24);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 14;
            this.progressBar.UseWaitCursor = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // status
            // 
            this.status.AllowDrop = true;
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(22, 466);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 0;
            // 
            // results
            // 
            this.results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.results.BackColor = System.Drawing.Color.Transparent;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(13, 10);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(676, 391);
            this.results.TabIndex = 16;
            // 
            // contentBox
            // 
            this.contentBox.AutoScroll = true;
            this.contentBox.Controls.Add(this.before_READOO_bg);
            this.contentBox.Controls.Add(this.results);
            this.contentBox.Location = new System.Drawing.Point(8, 12);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(702, 411);
            this.contentBox.TabIndex = 20;
            // 
            // before_READOO_bg
            // 
            this.before_READOO_bg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.before_READOO_bg.Image = global::READOO.Properties.Resources.BACKGROUND;
            this.before_READOO_bg.Location = new System.Drawing.Point(4, 6);
            this.before_READOO_bg.Name = "before_READOO_bg";
            this.before_READOO_bg.Size = new System.Drawing.Size(695, 402);
            this.before_READOO_bg.TabIndex = 17;
            this.before_READOO_bg.TabStop = false;
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Image = global::READOO.Properties.Resources.settings;
            this.settings.Location = new System.Drawing.Point(201, 453);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(109, 38);
            this.settings.TabIndex = 18;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // viewAsTextDoc
            // 
            this.viewAsTextDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAsTextDoc.BackColor = System.Drawing.SystemColors.Control;
            this.viewAsTextDoc.Image = global::READOO.Properties.Resources.view_As_Txt_Doc;
            this.viewAsTextDoc.Location = new System.Drawing.Point(389, 453);
            this.viewAsTextDoc.Name = "viewAsTextDoc";
            this.viewAsTextDoc.Size = new System.Drawing.Size(159, 38);
            this.viewAsTextDoc.TabIndex = 17;
            this.viewAsTextDoc.UseVisualStyleBackColor = true;
            this.viewAsTextDoc.Click += new System.EventHandler(this.view_KeywordsForHumans_Click);
            // 
            // done
            // 
            this.done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.done.BackColor = System.Drawing.SystemColors.Control;
            this.done.Image = global::READOO.Properties.Resources.done;
            this.done.Location = new System.Drawing.Point(554, 453);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(159, 38);
            this.done.TabIndex = 15;
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // ResultsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(720, 503);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.status);
            this.Controls.Add(this.viewAsTextDoc);
            this.Controls.Add(this.done);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cancel);
            this.MinimumSize = new System.Drawing.Size(736, 539);
            this.Name = "ResultsWindow";
            this.Text = "READOO RESULTS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exit);
            this.contentBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.before_READOO_bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button viewAsTextDoc;
        public System.Windows.Forms.Button settings;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Panel contentBox;
        private System.Windows.Forms.PictureBox before_READOO_bg;
    }
}