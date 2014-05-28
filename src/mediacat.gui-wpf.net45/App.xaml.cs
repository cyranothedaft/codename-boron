using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;



namespace mediacat.gui_wpf.net45 {
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application {
      protected override void OnStartup(StartupEventArgs e) {
         base.OnStartup(e);

         // Create the ViewModel and expose it using the View's DataContext
         var mainViewModel = new ViewModels.MainViewModel();
         var songsViewModel = new ViewModels.SongsViewModel();
         Views.MainView view = new Views.MainView();
         view.DataContext = mainViewModel;
         view.SetSongsViewModel(songsViewModel);
         view.Show();
      }


      private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
         MessageBox.Show(e.Exception.Message);
         e.Handled = true;
      }
   }
}
