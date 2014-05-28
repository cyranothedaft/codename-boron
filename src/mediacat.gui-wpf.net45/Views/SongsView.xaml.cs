﻿using System;
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
   /// Interaction logic for SongsView.xaml
   /// </summary>
   public partial class SongsView : UserControl {
      public SongsView() {
         InitializeComponent();
      }


      internal SongsViewModel ViewModel {
         set { this.DataContext = value; }
      }
   }
}
