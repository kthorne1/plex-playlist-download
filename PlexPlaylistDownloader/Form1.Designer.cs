namespace PlexPlaylistDownloader
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.DownloadOutput = new System.Windows.Forms.TextBox();
            this.OpenM3u8File_Button = new System.Windows.Forms.Button();
            this.SelectedM3u8FileLbl = new System.Windows.Forms.Label();
            this.SelectTargetFolderButton = new System.Windows.Forms.Button();
            this.SelectedTargetFolderLbl = new System.Windows.Forms.Label();
            this.Setup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbxEraseFolderBefore = new System.Windows.Forms.CheckBox();
            this.ckbxOverwriteFiles = new System.Windows.Forms.CheckBox();
            this.btnRemoveDuplicates = new System.Windows.Forms.Button();
            this.cbxDeleteOnLoad = new System.Windows.Forms.CheckBox();
            this.rbtnSortSong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnSortArtist = new System.Windows.Forms.RadioButton();
            this.rbtnSortRandom = new System.Windows.Forms.RadioButton();
            this.Setup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download Songs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DownloadOutput
            // 
            this.DownloadOutput.Location = new System.Drawing.Point(2, 150);
            this.DownloadOutput.Multiline = true;
            this.DownloadOutput.Name = "DownloadOutput";
            this.DownloadOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DownloadOutput.Size = new System.Drawing.Size(809, 590);
            this.DownloadOutput.TabIndex = 1;
            // 
            // OpenM3u8File_Button
            // 
            this.OpenM3u8File_Button.Location = new System.Drawing.Point(6, 19);
            this.OpenM3u8File_Button.Name = "OpenM3u8File_Button";
            this.OpenM3u8File_Button.Size = new System.Drawing.Size(75, 23);
            this.OpenM3u8File_Button.TabIndex = 2;
            this.OpenM3u8File_Button.Text = "Select m3u8";
            this.OpenM3u8File_Button.UseVisualStyleBackColor = true;
            this.OpenM3u8File_Button.Click += new System.EventHandler(this.OpenM3u8File_Button_Click);
            // 
            // SelectedM3u8FileLbl
            // 
            this.SelectedM3u8FileLbl.AutoSize = true;
            this.SelectedM3u8FileLbl.Location = new System.Drawing.Point(87, 24);
            this.SelectedM3u8FileLbl.MaximumSize = new System.Drawing.Size(150, 0);
            this.SelectedM3u8FileLbl.Name = "SelectedM3u8FileLbl";
            this.SelectedM3u8FileLbl.Size = new System.Drawing.Size(33, 13);
            this.SelectedM3u8FileLbl.TabIndex = 3;
            this.SelectedM3u8FileLbl.Text = "None";
            // 
            // SelectTargetFolderButton
            // 
            this.SelectTargetFolderButton.Location = new System.Drawing.Point(6, 19);
            this.SelectTargetFolderButton.Name = "SelectTargetFolderButton";
            this.SelectTargetFolderButton.Size = new System.Drawing.Size(75, 23);
            this.SelectTargetFolderButton.TabIndex = 4;
            this.SelectTargetFolderButton.Text = "To Folder";
            this.SelectTargetFolderButton.UseVisualStyleBackColor = true;
            this.SelectTargetFolderButton.Click += new System.EventHandler(this.SelectTargetFolderButton_Click);
            // 
            // SelectedTargetFolderLbl
            // 
            this.SelectedTargetFolderLbl.AutoSize = true;
            this.SelectedTargetFolderLbl.Location = new System.Drawing.Point(87, 24);
            this.SelectedTargetFolderLbl.MaximumSize = new System.Drawing.Size(150, 0);
            this.SelectedTargetFolderLbl.Name = "SelectedTargetFolderLbl";
            this.SelectedTargetFolderLbl.Size = new System.Drawing.Size(33, 13);
            this.SelectedTargetFolderLbl.TabIndex = 5;
            this.SelectedTargetFolderLbl.Text = "None";
            // 
            // Setup
            // 
            this.Setup.Controls.Add(this.cbxDeleteOnLoad);
            this.Setup.Controls.Add(this.OpenM3u8File_Button);
            this.Setup.Controls.Add(this.SelectedM3u8FileLbl);
            this.Setup.Location = new System.Drawing.Point(2, 5);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(389, 94);
            this.Setup.TabIndex = 6;
            this.Setup.TabStop = false;
            this.Setup.Text = "Playlist Load";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxEraseFolderBefore);
            this.groupBox1.Controls.Add(this.ckbxOverwriteFiles);
            this.groupBox1.Controls.Add(this.SelectedTargetFolderLbl);
            this.groupBox1.Controls.Add(this.SelectTargetFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(397, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Options";
            // 
            // ckbxEraseFolderBefore
            // 
            this.ckbxEraseFolderBefore.AutoSize = true;
            this.ckbxEraseFolderBefore.Location = new System.Drawing.Point(6, 71);
            this.ckbxEraseFolderBefore.Name = "ckbxEraseFolderBefore";
            this.ckbxEraseFolderBefore.Size = new System.Drawing.Size(198, 17);
            this.ckbxEraseFolderBefore.TabIndex = 2;
            this.ckbxEraseFolderBefore.Text = "Erase Target Folder Contents Before";
            this.ckbxEraseFolderBefore.UseVisualStyleBackColor = true;
            // 
            // ckbxOverwriteFiles
            // 
            this.ckbxOverwriteFiles.AutoSize = true;
            this.ckbxOverwriteFiles.Checked = true;
            this.ckbxOverwriteFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxOverwriteFiles.Location = new System.Drawing.Point(6, 48);
            this.ckbxOverwriteFiles.Name = "ckbxOverwriteFiles";
            this.ckbxOverwriteFiles.Size = new System.Drawing.Size(143, 17);
            this.ckbxOverwriteFiles.TabIndex = 1;
            this.ckbxOverwriteFiles.Text = "Overwrite Existing Songs";
            this.ckbxOverwriteFiles.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDuplicates
            // 
            this.btnRemoveDuplicates.Location = new System.Drawing.Point(8, 115);
            this.btnRemoveDuplicates.Name = "btnRemoveDuplicates";
            this.btnRemoveDuplicates.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveDuplicates.TabIndex = 8;
            this.btnRemoveDuplicates.Text = "Remove Duplicates";
            this.btnRemoveDuplicates.UseVisualStyleBackColor = true;
            this.btnRemoveDuplicates.Click += new System.EventHandler(this.btnRemoveDuplicates_Click);
            // 
            // cbxDeleteOnLoad
            // 
            this.cbxDeleteOnLoad.AutoSize = true;
            this.cbxDeleteOnLoad.Checked = true;
            this.cbxDeleteOnLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDeleteOnLoad.Location = new System.Drawing.Point(6, 48);
            this.cbxDeleteOnLoad.Name = "cbxDeleteOnLoad";
            this.cbxDeleteOnLoad.Size = new System.Drawing.Size(161, 17);
            this.cbxDeleteOnLoad.TabIndex = 6;
            this.cbxDeleteOnLoad.Text = "Delete Song Cache on Load";
            this.cbxDeleteOnLoad.UseVisualStyleBackColor = true;
            // 
            // rbtnSortSong
            // 
            this.rbtnSortSong.AutoSize = true;
            this.rbtnSortSong.Location = new System.Drawing.Point(6, 19);
            this.rbtnSortSong.Name = "rbtnSortSong";
            this.rbtnSortSong.Size = new System.Drawing.Size(50, 17);
            this.rbtnSortSong.TabIndex = 7;
            this.rbtnSortSong.TabStop = true;
            this.rbtnSortSong.Text = "Song";
            this.rbtnSortSong.UseVisualStyleBackColor = true;
            this.rbtnSortSong.CheckedChanged += new System.EventHandler(this.rbtnSortSong_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnSortRandom);
            this.groupBox2.Controls.Add(this.rbtnSortArtist);
            this.groupBox2.Controls.Add(this.rbtnSortSong);
            this.groupBox2.Location = new System.Drawing.Point(281, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 42);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            // 
            // rbtnSortArtist
            // 
            this.rbtnSortArtist.AutoSize = true;
            this.rbtnSortArtist.Location = new System.Drawing.Point(62, 20);
            this.rbtnSortArtist.Name = "rbtnSortArtist";
            this.rbtnSortArtist.Size = new System.Drawing.Size(48, 17);
            this.rbtnSortArtist.TabIndex = 8;
            this.rbtnSortArtist.TabStop = true;
            this.rbtnSortArtist.Text = "Artist";
            this.rbtnSortArtist.UseVisualStyleBackColor = true;
            this.rbtnSortArtist.CheckedChanged += new System.EventHandler(this.rbtnSortArtist_CheckedChanged);
            // 
            // rbtnSortRandom
            // 
            this.rbtnSortRandom.AutoSize = true;
            this.rbtnSortRandom.Location = new System.Drawing.Point(116, 19);
            this.rbtnSortRandom.Name = "rbtnSortRandom";
            this.rbtnSortRandom.Size = new System.Drawing.Size(65, 17);
            this.rbtnSortRandom.TabIndex = 9;
            this.rbtnSortRandom.TabStop = true;
            this.rbtnSortRandom.Text = "Random";
            this.rbtnSortRandom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRemoveDuplicates);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Setup);
            this.Controls.Add(this.DownloadOutput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Setup.ResumeLayout(false);
            this.Setup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DownloadOutput;
        private System.Windows.Forms.Button OpenM3u8File_Button;
        private System.Windows.Forms.Label SelectedM3u8FileLbl;
        private System.Windows.Forms.Button SelectTargetFolderButton;
        private System.Windows.Forms.Label SelectedTargetFolderLbl;
        private System.Windows.Forms.GroupBox Setup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbxEraseFolderBefore;
        private System.Windows.Forms.CheckBox ckbxOverwriteFiles;
        private System.Windows.Forms.Button btnRemoveDuplicates;
        private System.Windows.Forms.CheckBox cbxDeleteOnLoad;
        private System.Windows.Forms.RadioButton rbtnSortSong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnSortRandom;
        private System.Windows.Forms.RadioButton rbtnSortArtist;
    }
}

