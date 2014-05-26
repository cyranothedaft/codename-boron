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
         Views.MainView view = new Views.MainView();
         view.DataContext = new ViewModels.MainViewModel();
         view.Show();
      }


      private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
         MessageBox.Show(e.Exception.Message);
         e.Handled = true;
      }
   }
}
