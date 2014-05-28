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

      public MainViewModel() {
         //Songs = SongsModel.Current;
      }


      public ICommand ExitCommand {
         get { return ExitCommandDelegate ?? ( ExitCommandDelegate = new DelegateCommand(Exit) ); }
      }


      public SongsModel SongsData { get; private set; }


      private void Exit() {
         Application.Current.Shutdown();
      }
   }
}
