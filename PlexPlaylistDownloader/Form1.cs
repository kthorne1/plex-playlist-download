using PlexPlaylistDownloader.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlexPlaylistDownloader
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        private string _selectedM3u8File;
        public string SelectedM3u8File
        {
            get { return _selectedM3u8File; }
            set
            {
                _selectedM3u8File = value;
                OnPropertyChanged("SelectedM3u8File");
            }
        }

        private string _selectedTargetFolder;
        public string SelectedTargetFolder
        {
            get { return _selectedTargetFolder; }
            set
            {
                _selectedTargetFolder = value;
                OnPropertyChanged("SelectedTargetFolder");
            }
        }

        PlayListSongCollection _playListSongCollection;
        public PlayListSongCollection PlayList
        {
            get { return _playListSongCollection; }
            set
            {
                _playListSongCollection = value;
                OnPropertyChanged("PlayList");
            }
        }



        public string SongList
        {
            get { return PlayList.SongList; }
            set
            {
                PlayList.SongList = value;
                OnPropertyChanged("SongList");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion


        public Form1()
        {
            InitializeComponent();
            SelectedM3u8FileLbl.DataBindings.Add(new Binding("Text", this, "SelectedM3u8File"));
            SelectedTargetFolderLbl.DataBindings.Add(new Binding("Text", this, "SelectedTargetFolder"));

            _playListSongCollection = new PlayListSongCollection();
            PlayList.PropertyChanged += PlayListChanged;
            DownloadOutput.DataBindings.Add("Text", this, "SongList", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Loop through the playlist collection and copy from each path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (ckbxEraseFolderBefore.Checked)
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(SelectedTargetFolder);
                di.Empty();
            }

            // DownloadOutput.Text = "Copying...";
            foreach (var thisSong in PlayList)
            {
                string targetName = (thisSong.Artist + "_" + thisSong.Title)
                    .Replace("?", "")
                    .Replace("/", " ")
                    .Replace(":", " ")
                    + thisSong.Extension;
                File.Copy(
                    thisSong.Path.Replace("/share/Multimedia", @"h:"),
                    SelectedTargetFolder + "/" + targetName,
                    ckbxOverwriteFiles.Checked);

                // DownloadOutput.Text += Environment.NewLine + thisSong.Title + thisSong.Extension + " Copied..."; ;
            }
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Opens m3u8 file and loads the play list collection with the included songs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenM3u8File_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Plex Export|*.m3u8";
            openFileDialog1.Title = "Select a Playlist Export";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SelectedM3u8File = openFileDialog1.FileName;
                string line;
                using (Stream stream = openFileDialog1.OpenFile())
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        if(cbxDeleteOnLoad.Checked)
                            PlayList.ClearItems();

                        line = sr.ReadLine();
                        while (line != null)
                        {
                            if (line.StartsWith("#{\"Id\":"))
                            {
                                List<string> m3u8SongExportList = new List<string>();
                                m3u8SongExportList.Add(line);
                                m3u8SongExportList.Add(sr.ReadLine());
                                m3u8SongExportList.Add(sr.ReadLine());

                                PlayListSong thisSong = new PlayListSong(m3u8SongExportList);

                                PlayList.Add(thisSong);

                                //DownloadOutput.AppendText(Environment.NewLine + thisSong.Path);
                                //if (DownloadOutput.Lines.Count() != 0)
                                //    DownloadOutput.Text += Environment.NewLine;

                                //DownloadOutput.Text += thisSong.Title + thisSong.Extension;

                            }

                            line = sr.ReadLine();
                        }
                    }
                };
            }
        }

        private void SelectTargetFolderButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.SelectedPath = @"c:/temp/download";


            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SelectedTargetFolder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnRemoveDuplicates_Click(object sender, EventArgs e)
        {
            //var deDupedCollection = new PlayListSongCollection();


            //var xdeDupedCollection = PlayList
            //    .GroupBy(t => t.Title, (key, group) => group.First<PlayListSong>())
            //    .GroupBy(a => a.Artist, (key1, group1) => group1.First<PlayListSong>())
            //    .ToList<PlayListSong>();

            //PlayList.UpdateSongCollection(xdeDupedCollection);
            PlayList.RemoveDuplicates();


        }

        private void PlayListChanged(Object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SongList":
                    OnPropertyChanged("PlayList");
                    DownloadOutput.DataBindings["Text"].ReadValue();
                    break;
            }
        }

        private void rbtnSortSong_CheckedChanged(object sender, EventArgs e)
        {
            PlayList.Sort();
        }

        private void rbtnSortArtist_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
