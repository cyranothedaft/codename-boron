using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using mediacat.gui_wpf.net45.Commands;
using mediacat.gui_wpf.net45.Models;



namespace mediacat.gui_wpf.net45.ViewModels {
   internal class MainViewModel : ViewModelBase {
      private DelegateCommand ExitCommandDelegate;

      public MainViewModel(SourcesViewModel sourcesViewModel, SongsViewModel songsViewModel) {
         SourcesViewModel = sourcesViewModel;
         SongsViewModel = songsViewModel;
      }


      public SourcesViewModel SourcesViewModel { get; private set; }

      public SongsViewModel SongsViewModel { get; private set; }


      public string HeaderText { get; set; }


      public ICommand ExitCommand {
         get { return ExitCommandDelegate ?? ( ExitCommandDelegate = new DelegateCommand(Exit) ); }
      }


      private void Exit() {
         Application.Current.Shutdown();
      }
   }
}
