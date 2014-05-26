using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;



namespace mediacat.gui_wpf.net45.Commands {
   /// <summary>
   /// This class facilitates associating a key binding in XAML markup to a command
   /// defined in a View Model by exposing a Command dependency property.
   /// The class derives from Freezable to work around a limitation in WPF when data-binding from XAML.
   /// 
   /// Initial code copied from:
   /// "A Practical Quick-start Tutorial on MVVM in WPF" By Dr. Song Li, 21 May 2010
   /// http://www.codeproject.com/Articles/81484/A-Practical-Quick-start-Tutorial-on-MVVM-in-WPF
   /// </summary>
   internal class CommandReference : Freezable, ICommand {
      public CommandReference() {
      }


      public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof( ICommand ), typeof( CommandReference ),
                                                                                              new PropertyMetadata(new PropertyChangedCallback(OnCommandChanged)));

      public ICommand Command {
         get { return ( ICommand ) GetValue(CommandProperty); }
         set { SetValue(CommandProperty, value); }
      }

      #region ICommand Members

      public event EventHandler CanExecuteChanged;


      public bool CanExecute(object parameter) {
         if ( Command != null )
            return Command.CanExecute(parameter);
         return false;
      }


      public void Execute(object parameter) {
         Command.Execute(parameter);
      }


      private static void OnCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
         CommandReference commandReference = d as CommandReference;
         ICommand oldCommand = e.OldValue as ICommand;
         ICommand newCommand = e.NewValue as ICommand;

         if ( oldCommand != null ) {
            oldCommand.CanExecuteChanged -= commandReference.CanExecuteChanged;
         }
         if ( newCommand != null ) {
            newCommand.CanExecuteChanged += commandReference.CanExecuteChanged;
         }
      }

      #endregion ICommand Members

      #region Freezable

      protected override Freezable CreateInstanceCore() {
         throw new NotImplementedException();
      }

      #endregion Freezable
   }
}
