using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediacat.gui_wpf.net45.Models {
   public class Song {
      public string Artist { get; set; }
      public string Title { get; set; }


      public Song(string artist, string title) {
         Artist = artist;
         Title = title;
      }
   }
}
