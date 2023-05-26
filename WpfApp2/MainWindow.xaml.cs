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
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CommandBindingNew_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }
        private void CommandBindingNew_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            MessageBox.Show("New MenuItem Clicked.");
        }
        private void CommandBindingOpen_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }
        private void CommandBindingOpen_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            MessageBox.Show("Open MenuItem Clicked.");
        }
        private void CommandBindingCopy_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }
        private void CommandBindingCopy_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            MessageBox.Show("Copy MenuItem Clicked.");
        }
        private void CommandBindingCut_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }
        private void CommandBindingCut_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            MessageBox.Show("Cut MenuItem Clicked.");
        }
        private void CommandBindingPaste_CanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }
        private void CommandBindingPaste_Executed(object sender, ExecutedRoutedEventArgs args)
        {
            MessageBox.Show("Cut MenuItem Clicked.");
        }
    }
}
