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
using System.Windows.Shapes;

namespace day11Evteev
{
    public partial class Window5 : Window
    {

        public Window5()
        {
            InitializeComponent();
        }

        private void ButtonO_Click(object sender, RoutedEventArgs e)
        {
            Window6 otherWindow = new Window6();
            otherWindow.Show();
            this.Close();
        }
        private void ButtonD_Click(object sender, RoutedEventArgs e)
        {
            Window7 otherWindow = new Window7();
            otherWindow.Show();
            this.Close();
        }
    }
}
       