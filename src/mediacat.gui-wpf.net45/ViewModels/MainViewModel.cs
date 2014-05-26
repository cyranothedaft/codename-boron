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
      private DelegateCommand exitCommand;

      public SongsModel Songs { get; set; }
      public string SongArtistToAdd { get; set; }
      public string SongTitleToAdd { get; set; }

      public MainViewModel() {
         Songs = SongsModel.Current;
      }


      public ICommand ExitCommand {
         get {
            if ( exitCommand == null ) {
               exitCommand = new DelegateCommand(Exit);
            }
            return exitCommand;
         }
      }


      private void Exit() {
         Application.Current.Shutdown();
      }


      private ICommand _addSongCommand;

      public ICommand AddSongCommand {
         get {
            if ( _addSongCommand == null ) {
               _addSongCommand = new DelegateCommand(delegate() {
                                                        SongArtistToAdd = SongArtistToAdd.Trim();
                                                        SongTitleToAdd = SongTitleToAdd.Trim();

                                                        if ( SongArtistToAdd.Length == 0 ) throw new Exception("Missing artist name.");
                                                        if ( SongTitleToAdd.Length == 0 ) throw new Exception("Missing title.");

                                                        Songs.AddSong(SongArtistToAdd, SongTitleToAdd);
                                                     });
            }

            return _addSongCommand;
         }
      }

   }
}
