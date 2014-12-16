using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediacat.gui_wpf.net45.Models {
   internal class SourceModel : MediaSource {
      public SourceModel(MediaSourceType sourceType)
         : base(sourceType) {
      }

      public string Name { get; set; }
      public string Status { get; set; }
   }
}
