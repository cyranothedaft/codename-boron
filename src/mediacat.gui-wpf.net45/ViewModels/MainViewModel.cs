using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using mediacat.gui_wpf.net45.Commands;



namespace mediacat.gui_wpf.net45.ViewModels {
   internal class MainViewModel : ViewModelBase {
      private DelegateCommand ExitCommandDelegate;

      public MainViewModel(SourceExplorerViewModel sourceExplorerViewModel) {
         SourceExplorerViewModel = sourceExplorerViewModel;
      }


      public SourceExplorerViewModel SourceExplorerViewModel { get; private set; }


      public string HeaderText { get; set; }


      public ICommand ExitCommand {
         get { return ExitCommandDelegate ?? ( ExitCommandDelegate = new DelegateCommand(Exit) ); }
      }


      private void Exit() {
         Application.Current.Shutdown();
      }
   }
}
