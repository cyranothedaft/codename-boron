using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mediacat.gui_wpf.net45.Commands;
using mediacat.gui_wpf.net45.Models;



namespace mediacat.gui_wpf.net45.ViewModels {
   internal sealed class SourcesViewModel : ViewModelBase {
      public SourcesViewModel(SourcesModel sourcesModel) {
         SourcesData = sourcesModel;
      }

      public string Title { get; set; }

      public SourcesModel SourcesData { get; private set; }
   }
}
