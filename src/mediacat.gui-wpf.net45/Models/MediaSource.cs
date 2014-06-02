using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediacat.gui_wpf.net45.Models {
   internal enum MediaSourceType {
      MusicLibrary,
   }



   internal class MediaSource {
      public MediaSourceType SourceType { get; private set; }


      public MediaSource(MediaSourceType sourceType) {
         SourceType = sourceType;
         throw new NotImplementedException();
      }
   }
}
