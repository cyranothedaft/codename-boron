using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediacat.gui_wpf.net45.Models {
   internal class MediaSourceWatcher {
      public MediaSource MediaSource { get; private set; }


      public MediaSourceWatcher(MediaSource mediaSource) {
         MediaSource = mediaSource;
      }
   }
}
