using System;
using System.Windows;
using System.Windows.Controls;

namespace day11Evteev
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            Window1 otherWindow = new Window1();
            otherWindow.Show();
            this.Close();
        }
    }
}


