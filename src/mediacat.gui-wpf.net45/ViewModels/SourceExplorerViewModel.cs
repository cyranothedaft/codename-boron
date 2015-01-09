using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using mediacat.gui_wpf.net45.Commands;



namespace mediacat.gui_wpf.net45.ViewModels {
   internal class SourceExplorerViewModel : ViewModelBase {
      private DelegateCommand ExitCommandDelegate;

      public SourceExplorerViewModel(SourcesViewModel sourcesViewModel, SongsViewModel songsViewModel) {
         SourcesViewModel = sourcesViewModel;
         SongsViewModel = songsViewModel;
      }


      public SourcesViewModel SourcesViewModel { get; private set; }

      public SongsViewModel SongsViewModel { get; private set; }


      public string HeaderText { get; set; }
   }
}
