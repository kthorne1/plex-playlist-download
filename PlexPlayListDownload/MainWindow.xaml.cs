using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlexPlayListDownload
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //ObservableCollection<PlayListSong> playListCollection = new ObservableCollection<PlayListSong>();


        //private string _name2;
        
        //public string Name2
        //{
        //    get { return _name2; }
        //    set
        //    {
        //        if (value != _name2)
        //        {
        //            _name2 = value;
        //            OnPropertyChanged("Name2");
        //        }
        //    }
        //}
        public PlayListSongCollection PlayListSongs { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            PlayListSongs = new PlayListSongCollection();

            //PropertyChanged += MainWindow_PropertyChanged;

            //playListCollection.CollectionChanged += PlayListCollection_CollectionChanged;

        }

        //private void MainWindow_PropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void PlayListCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    onPlayListPropertChanged(e);
        //}

        //private onPlayListPropertChanged(NotifyCollectionChangedEventArgs e)
        //{

        //}
        private void RunDownload_Click(object sender, RoutedEventArgs e)
        {
            string line;

            Dictionary<string,string> linesForDownload = new Dictionary<string, string>();
            try
            {
                //using (StreamReader sr = new StreamReader(@"C:\temp\Shawn Mendes.m3u8"))
                //{
                //    line = sr.ReadLine();
                //    while (line != null)
                //    {
                //        //write the lie to console window
                //        Console.WriteLine(line);
                //        //Read the next line
                //        line = sr.ReadLine();
                //        if (line.StartsWith("#{\"Id\":"))
                //        {
                //            List<string> m3u8SongExportList = new List<string>();
                //            m3u8SongExportList.Add(line);
                //            m3u8SongExportList.Add(sr.ReadLine());
                //            m3u8SongExportList.Add(sr.ReadLine());

                //            PlayListSong thisSong = new PlayListSong(m3u8SongExportList);

                //            //DownloadOutput.AppendText(Environment.NewLine + thisSong.Path);
                //            DownloadOutput.Text = "NEW SONG";
                //        }
                //    }



                //    //close the file
                //    sr.Close();
                //}
                //Console.ReadLine();
            }
            catch(Exception err)
            {
                Console.WriteLine("Exception: " + err.Message);
            }
               finally 
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
}
