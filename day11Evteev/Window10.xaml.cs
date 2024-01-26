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
    public partial class Window10 : Window
    {

        public Window10()
        {
            InitializeComponent();
        }

        private void ButtonT_Click(object sender, RoutedEventArgs e)
        {
            Window11 otherWindow = new Window11();
            otherWindow.Show();
            this.Close();
        }

        private void ButtonN_Click(object sender, RoutedEventArgs e)
        {
            Window12 otherWindow = new Window12();
            otherWindow.Show();
            this.Close();
        }

    }
}
