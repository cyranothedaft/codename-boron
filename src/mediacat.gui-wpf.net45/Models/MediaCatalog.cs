using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediacat.gui_wpf.net45.Models {
   internal class MediaCatalog : ObservableCollection<Song> {
      private static readonly object _threadLock = new Object();
      private static MediaCatalog current = null;


      private List<MediaSource> _mediaSources;
      private List<MediaSourceWatcher> _mediaSourceWatchers;


      public static MediaCatalog Current {
         get {
            lock ( _threadLock )
               if ( current == null )
                  current = new MediaCatalog();

            return current;
         }
      }


      private MediaCatalog() {
         // initialize media sources
         _mediaSources = new List<MediaSource>()
                         {
                            new MediaSource(MediaSourceType.MusicLibrary),
                         };

         // initialize media source watchers
         _mediaSourceWatchers = new List<MediaSourceWatcher>();
         foreach ( MediaSource mediaSource in _mediaSources )
            _mediaSourceWatchers.Add(new MediaSourceWatcher(mediaSource));
      }


      public void AddSong(string artist, string title) {
         Song song = new Song(artist, title);
         Add(song);
      }
   }
}
