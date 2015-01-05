using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using mediacat.gui_wpf.net45.Models;
using mediacat.gui_wpf.net45.ViewModels;



namespace mediacat.gui_wpf.net45 {
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application {
      protected override void OnStartup(StartupEventArgs e) {
         base.OnStartup(e);

         // Create the ViewModel and expose it using the View's DataContext


         var sourcesModel = new SourcesModel();
         sourcesModel.AddSource("Silent Street", MediaSourceType.MusicLibrary, "Available");
         sourcesModel.AddSource("Source 2", MediaSourceType.MusicLibrary, "Missing");

         var songsModel = new SongsModel();
         songsModel.AddSong("Artist 1", "Title 1");
         songsModel.AddSong("Artist 2", "Title 2");

         var sourcesViewModel = new SourcesViewModel(sourcesModel);
         sourcesViewModel.Title = "Sources Title...";

         var songsViewModel = new SongsViewModel(songsModel);
         songsViewModel.Title = "Songs Title...";

         var mainViewModel = new MainViewModel(sourcesViewModel, songsViewModel);
         mainViewModel.HeaderText = "Header Text...";

         //var songsViewModel = new ViewModels.SongsViewModel();

         Views.MainView view = new Views.MainView();
         view.ViewModel = mainViewModel;
         view.Show();
      }


      private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
         MessageBox.Show(e.Exception.Message);
         e.Handled = true;
      }
   }
}
