﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediacat.gui_wpf.net45.Models {
   internal class SomeStaticModel : ObservableCollection<Song> {
      private static readonly object _threadLock = new Object();
      private static SomeStaticModel current = null;

      public static SomeStaticModel Current {
         get {
            lock ( _threadLock )
               if ( current == null )
                  current = new SomeStaticModel();

            return current;
         }
      }


      private SomeStaticModel() {
         for ( int i = 1; i <= 5; i++ ) {
            Song aStudent = new Song(
               string.Format("artist #{0}", i),
               string.Format("title #{0}", i));
            Add(aStudent);
         }
      }


      public void AddSong(string artist, string title) {
         Song song = new Song(artist, title);
         Add(song);
      }
   }
}
