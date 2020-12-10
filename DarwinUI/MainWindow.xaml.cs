using System;
using System.Windows;
using System.Windows.Input;

namespace DarwinUI
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

        private void drag(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void exitwin(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void minimisewin(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
