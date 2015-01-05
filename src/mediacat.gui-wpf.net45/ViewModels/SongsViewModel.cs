using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mediacat.gui_wpf.net45.Commands;
using mediacat.gui_wpf.net45.Models;



namespace mediacat.gui_wpf.net45.ViewModels {
   internal class SongsViewModel : ViewModelBase {
      public string Title { get; set; }
      public SongsModel SongsData { get; private set; }


      public SongsViewModel(SongsModel songsModel) {
         SongsData = songsModel;
      }
   }
}
