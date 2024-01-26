using System;
using System.Windows;
using System.Windows.Controls;
using day11Evteev;

namespace day11Evteev
{
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            Window2 otherWindow = new Window2();
            otherWindow.Show();
            this.Close();
        }

        private void ButtonB_Click(object sender, RoutedEventArgs e)
        {
            Window3 otherWindow = new Window3();
            otherWindow.Show();
            this.Close();
        }
    }
}