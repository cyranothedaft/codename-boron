using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mediacat.gui_wpf.net45.ViewModels;



namespace mediacat.gui_wpf.net45.Views {
   /// <summary>
   /// Interaction logic for MainView.xaml
   /// </summary>
   public partial class MainView : Window {
      public MainView() {
         InitializeComponent();
      }


      internal MainViewModel ViewModel {
         set {
            this.DataContext = value;
            this.SourcesView.ViewModel = value.SourcesViewModel;
            this.SongsView.ViewModel = value.SongsViewModel;
         }
      }
   }
}
