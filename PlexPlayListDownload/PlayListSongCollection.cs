using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PlexPlayListDownload
{

    public class PlayListCollectionMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return String.Format("{0} {1}", "Hello", "World");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class PlayListSongCollection : ObservableCollection<PlayListSong>
    {
        private List<PlayListSong> _playListSongsList ;

        public List<string> PathList
        {
            get
            {
                var test = new List<string>();
                test.Add("Hello World");
                return test;
            }
        }

        //public int Count => _playListSongsList.Count;

        //public bool IsReadOnly => throw new NotImplementedException();



        //public void Add(PlayListSong item)
        //{
        //    _playListSongsList.Add(item);
        //}

        //public void Clear()
        //{
        //    _playListSongsList.Clear();
        //}

        //public bool Contains(PlayListSong item)
        //{
        //    return _playListSongsList.Contains(item);
        //}

        //public void CopyTo(PlayListSong[] array, int arrayIndex)
        //{
        //    array = _playListSongsList.ToArray();
        //}



        //public IEnumerator<PlayListSong> GetEnumerator()
        //{
        //    return _playListSongsList.GetEnumerator();
        //}

        //public bool Remove(PlayListSong item)
        //{
        //    return _playListSongsList.Remove(item);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return _playListSongsList.GetEnumerator();
        //}
    }
}
