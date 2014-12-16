using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace mediacat.gui_wpf.net45.Models {
   internal sealed class SourcesModel : ObservableCollection<SourceModel> {
      public void AddSource(string name, MediaSourceType type, string status) {
         SourceModel source = new SourceModel(type)
                              {
                                 Name = name,
                                 Status = status,
                              };
         Add(source);
      }
   }
}
