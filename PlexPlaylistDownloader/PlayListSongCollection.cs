using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlexPlaylistDownloader
{
    public class PlayListSongCollection : ObservableCollection<PlayListSong>
    {
        //private List<PlayListSong> _playListSongsList ;
        //private string _songList;

        string _songList;
        public string SongList
        {
            get
            {
                return _songList;
            }
            set
            {
                _songList = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("SongList"));
            }
        }

        public List<PlayListSong> PathList
        {
            get
            {
                return this.ToList<PlayListSong>(); ;
            }
        }

        public PlayListSongCollection()
        {
            //PropertyChanged += onPlayListPropertyChanged;
            CollectionChanged += onPlayListCollectionChanged;
        }


        private void onPlayListCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (var song in e.NewItems)
                    {
                        if (!string.IsNullOrEmpty(_songList))
                            _songList += Environment.NewLine;
                        _songList += ((PlayListSong)song).Title; //String.Join(Environment.NewLine, this.Select(pl => pl.Title).ToArray());
                    }
                    InvokePropertyChanged(new PropertyChangedEventArgs("SongList"));
                    break;

                case NotifyCollectionChangedAction.Move:
                    {
                        _songList = string.Empty;
                        foreach (var song in this)
                        {
                            if (!string.IsNullOrEmpty(_songList))
                                _songList += Environment.NewLine;
                            _songList += ((PlayListSong)song).Title; //String.Join(Environment.NewLine, this.Select(pl => pl.Title).ToArray());
                        }
                        InvokePropertyChanged(new PropertyChangedEventArgs("SongList"));
                    }
                    break;

                case NotifyCollectionChangedAction.Remove:
                case NotifyCollectionChangedAction.Reset:
                    _songList = string.Empty;
                    InvokePropertyChanged(new PropertyChangedEventArgs("SongList"));
                    break;

            }
        }

        //private void onPlayListPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}


        #region Implementation of INotifyPropertyChanged
        /// <summary>
        /// EVENT PROPERTY CHANGED
        /// </summary>
        new public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

        #endregion // END REGION

        public void UpdateSongCollection(IEnumerable<PlayListSong> songList)
        {
            this.ClearItems();
            songList.ToList().ForEach(song => this.Add(song));
            InvokePropertyChanged(new PropertyChangedEventArgs("CollectionList"));
        }

        new public void Add(PlayListSong song)
        {
            base.Add(song);
            InvokePropertyChanged(new PropertyChangedEventArgs("CollectionList"));
        }

        new public void ClearItems()
        {
            base.ClearItems();
            _songList = string.Empty;
            InvokePropertyChanged(new PropertyChangedEventArgs("CollectionList"));
        }

        public void RemoveDuplicates()
        {
            List<int> removeIndex = new List<int>();
            bool allMatchesRemoved = false;
            bool matchFound = false;
            while (!allMatchesRemoved)
            {
                matchFound = false;
                for (int indexOfThisPLS = 0; indexOfThisPLS < Count; indexOfThisPLS++)
                {
                    for (int matchCheckIndex = 0; matchCheckIndex < Count; matchCheckIndex++)
                    {
                        if (matchCheckIndex != indexOfThisPLS &&
                            Items[matchCheckIndex].Title == Items[indexOfThisPLS].Title &&
                            Items[matchCheckIndex].Artist == Items[indexOfThisPLS].Artist)
                        {
                            this.Remove(Items[matchCheckIndex]);
                            matchFound = true;
                            break;
                        }
                    }
                    if (matchFound)
                        break;
                }
                if (!matchFound)
                    allMatchesRemoved = true;
            }
        }

            //removeIndex.ForEach(i => Remove(Items[i]));


            //this.ToList().ForEach(pls =>
            //{
            //    int indexOfThisPLS = IndexOf(pls);
            //    this.ToList().ForEach(matchCheck =>
            //    {
            //        int matchCheckIndex = IndexOf(matchCheck);
            //        if (matchCheck.Title == pls.Title && matchCheck.Artist == pls.Artist && matchCheckIndex != indexOfThisPLS)
            //            this.Remove(matchCheck);
            //    });
            //});
        


        public void Sort()
        {
            var test = this.Items.ToList<PlayListSong>();
            test.Sort((s1, s2) => string.Compare(s1.Title, s2.Title));
            //test.ForEach(s =>
            //{
            //    if (!string.IsNullOrEmpty(_songList))
            //    {
            //        _songList += Environment.NewLine;
            //    }
            //    _songList += s.Title;
            //});
            
            for (int index = 0; index < test.Count(); index++)
            {
                Move(
                this.IndexOf(test[index]),
                index);
            }

            InvokePropertyChanged(new PropertyChangedEventArgs("SongList"));

        }
    }
}
