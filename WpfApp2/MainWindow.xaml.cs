using System.Windows;
using System.Windows.Input;

namespace WpfApp2
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ExitCommandContext();
            this.TestList.Visibility = Visibility.Hidden;
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CommandBindingNew_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            CommandBindingBase_CanExecute(sender, args);
        }
        private void CommandBindingNew_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            CommandBindingBase_Executed("New");
        }
        private void CommandBindingOpen_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            CommandBindingBase_CanExecute(sender, args);
        }
        private void CommandBindingOpen_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            CommandBindingBase_Executed("Open");
        }
        private void CommandBindingCopy_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            CommandBindingBase_CanExecute(sender, args);

        }
        private void CommandBindingCopy_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            CommandBindingBase_Executed("Copy");
        }
        private void CommandBindingCut_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            CommandBindingBase_CanExecute(sender, args);
        }
        private void CommandBindingCut_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            CommandBindingBase_Executed("Cut");
        }
        private void CommandBindingPaste_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            CommandBindingBase_CanExecute(sender, args);

        }
        private void CommandBindingPaste_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            CommandBindingBase_Executed("Paste");
        }

        private void CommandBindingBase_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }

        private void CommandBindingBase_Executed(string header)
        {
            MessageBox.Show($"{header} MenuItem Clicked.");
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            this.TestList.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            this.TestList.Visibility = Visibility.Hidden;
        }
    }
}
