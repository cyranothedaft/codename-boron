using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediacat.gui_wpf.net45.Models {
   internal class SongsModel : ObservableCollection<Song> {
      public SongsModel() {
      }


      public void AddSong(string artist, string title) {
         Song song = new Song(artist, title);
         Add(song);
      }
   }
}
