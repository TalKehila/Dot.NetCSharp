using System;
using System.Windows;

namespace WpfMemoryLeak
{
    public partial class MainWindow : Window
    {
        OtherWindow win;
        public MainWindow() => InitializeComponent();

        private void NewWinClick(object sender, RoutedEventArgs e)
        {
            if (win != null)
            {
                win = new OtherWindow(); //countRef++
            }
            win.Show();
            win.Hide();

            //var tmp = win;              //countRef++
            win = null;                 //countRef--

            GC.Collect();
        }
    }
}